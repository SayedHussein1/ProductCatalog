
using Microsoft.EntityFrameworkCore;
using App.Domain.Interfaces;
 
using App.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Model;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography.X509Certificates;

namespace App.Infra.Data.Repositories
{

    public class ProductsRepository : IProductsRepository
    {
        public AppDbContext _context;
        public readonly IHttpContextAccessor _httpContextAccessor;
        public ProductsRepository(AppDbContext context,IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<Products> GetItemById(int Id)
        {
            return await _context.Products
                .Where(x => x.Id == Id && !x.IsDeleted)
                .Include(x => x.SwitchMapping)
                .ThenInclude(x => x.Category)
                  .Include(x => x.SwitchMapping)
                .Include(x => x.CreateByUser)
                .Include(x => x.Category)
                .Include(x => x.ProductImage)
                .FirstOrDefaultAsync().ConfigureAwait(false);
        }
        public async Task<Products> GetProductById(int Id)
        {
            return await _context.Products
                .Where(x => x.Id == Id && !x.IsDeleted)
                .FirstOrDefaultAsync().ConfigureAwait(false);
        }
      
        public async Task<bool> ChangeStatusItem(int id, bool status)
        {
            var dbObj = await _context.Products.
                Where(x => x.Id == id).FirstOrDefaultAsync();
            if (dbObj == null)
            {
                return false;
            }
            dbObj.IsPublish = status;
           await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteItem(int id)
        {
            var dbObj = await _context.Products.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (dbObj == null)
            {
                return false;
            }
            dbObj.IsDeleted = true;
          await  _context.SaveChangesAsync();

            return true;
        }
      
        public async Task SaveItem(Products obj)
        {
            if (obj.Id == 0)
            {
                obj.IsDeleted = false;
                obj.IsPublish = true;
                obj.CreateDate = DateTime.Now;

                await _context.Products.AddAsync(obj);
            }
            else
            {
                _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }
        public async Task<bool> AddHistory(ProductsHistory obj)
        {
            var checkOldHistory = _context.ProductsHistory.Where(s => s.ProductId == obj.ProductId &&
                 s.MobileAppId == obj.MobileAppId);
            if(! await checkOldHistory.AnyAsync())
            {
                await _context.ProductsHistory.AddAsync(obj);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<Tuple<IList<Products>, int>> LoadItemsData(string Search, int StatusId, int CategoryId, int SubCategoryId, int jtStartIndex = 0,
            int jtPageSize = 10, string order = null, string orderDir = null)
        {
            var AllListCount = 0;
            var dataQuery = _context.Products
               .Where(x => x.IsDeleted != true &&
                (StatusId == 0 || (StatusId == 1 && x.IsPublish == true && x.IsSolid == false)
                || (StatusId == 2 && x.IsPublish == false && x.IsSolid == false)
                || (StatusId == 3 && x.IsSolid == true)));
            if (CategoryId > 0)
            {
                dataQuery = dataQuery.Where(s => s.CategoryId == CategoryId);
            }  
           
            var result = dataQuery.Include(x => x.Category).Include(x => x.CreateByUser).AsQueryable();
            if (!string.IsNullOrEmpty(order))
            {
                switch (order)
                {
                    case "0":
                        result = orderDir == "asc" ? result.OrderBy(x => x.Title) : result.OrderByDescending(x => x.Title);
                        break;
                    case "1":
                        result = orderDir == "asc" ? result.OrderBy(x => x.Category.Name) : result.OrderByDescending(x => x.Category.Name);
                        break;
                   
                    case "3":
                        result = orderDir == "asc" ? result.OrderBy(x => x.CreateByUser.FullName) : result.OrderByDescending(x => x.CreateByUser.FullName);
                        break;
                  
                    case "4":
                        result = orderDir == "asc" ? result.OrderBy(x => x.CreateDate) : result.OrderByDescending(x => x.CreateDate);
                        break;
                }
            }
            else
            {
                result = result.
                    OrderByDescending(x => x.Id);
            }
            AllListCount = await dataQuery.CountAsync();
            return new Tuple<IList<Products>, int>(await result.Skip(jtStartIndex).Take(jtPageSize).ToListAsync().ConfigureAwait(false), AllListCount);
        }






        public IList<Products> LoadDataForHomePage(int CategoryId , bool isAdmin)
        {
            var dataQuery = _context.Products
               .Where(x => x.IsDeleted != true && x.IsPublish != false) ;

            if (CategoryId > 0)
            {
                dataQuery = dataQuery.Where(s => s.CategoryId == CategoryId);
            }

            if (!isAdmin )
            {
                dataQuery = dataQuery.Where(p => p.StartDate.AddDays(p.Duration).Date > DateTime.Now.Date);
            }

            var result = dataQuery.Include(x => x.Category).Include(x => x.CreateByUser).AsQueryable();

            return result.ToList();
        }




    }
}
