﻿
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
 
namespace App.Infra.Data.Repositories
{

    public class CategoryRepository : ICategoryRepository
    {
        public AppDbContext _context;
        public readonly IHttpContextAccessor _httpContextAccessor;
        public CategoryRepository(AppDbContext context,IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<Category> GetItemById(int Id)
        {
            return await _context.Category
                .Where(x => x.Id == Id && !x.IsDeleted).FirstOrDefaultAsync();
        }
        public async Task<bool> ChangeStatusItem(int id, bool status)
        {
            var dbObj = await _context.Category.
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
            var dbObj = await _context.Category.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (dbObj == null)
            {
                return false;
            }
            dbObj.IsDeleted = true;
          await  _context.SaveChangesAsync();

            return true;
        }
        public async Task SaveItem(Category obj)
        {
            if (obj.Id == 0)
            {
                obj.IsDeleted = false;
                obj.IsPublish = true;
                obj.CreateDate = DateTime.Now;
                obj.UpdateDate = DateTime.Now;
                await _context.Category.AddAsync(obj);
            }
            else
            {
                obj.UpdateDate = DateTime.Now;
                _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            await _context.SaveChangesAsync();
        }
        public async Task<Tuple<IList<Category>, int>> LoadItemsData(string Search, int StatusId,DateTime? StartDate, DateTime? EndDate, int jtStartIndex = 0,
            int jtPageSize = 10, string order = null, string orderDir = null)
        {
           var AllListCount = 0;
            var dataQuery = _context.Category
                .Where(x => x.IsDeleted != true &&
                (StatusId == 0 || (StatusId == 1 && x.IsPublish == true)
                || (StatusId == 2 && x.IsPublish == false)));

            if (StartDate.HasValue)
            {
                dataQuery = dataQuery.Where(x => x.UpdateDate >= StartDate);
            }
            if (EndDate.HasValue)
            {
                dataQuery = dataQuery.Where(x => x.UpdateDate <= EndDate);
            }
            

            var result = dataQuery.AsQueryable();
            if (!string.IsNullOrEmpty(order))
            {
                switch (order)
                {
                    case "0":
                        result = orderDir == "asc" ? result.OrderBy(x => x.Name) : result.OrderByDescending(x => x.Name);
                        break;
                }
            }
            else
            {
                result = result.
                    OrderByDescending(x => x.Id);
            } 
                AllListCount =await dataQuery.CountAsync();
            return new Tuple<IList<Category>, int>(await result.Skip(jtStartIndex).Take(jtPageSize).ToListAsync().ConfigureAwait(false), AllListCount);

            
        }

        
    }
}
