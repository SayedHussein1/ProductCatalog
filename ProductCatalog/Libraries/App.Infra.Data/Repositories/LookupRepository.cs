
using Microsoft.EntityFrameworkCore;
using App.Domain.Interfaces;
using App.Domain.Model;
using App.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Repositories
{

    public class LookupRepository : ILookupRepository
    {
        public AppDbContext _context;
        public LookupRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IList<AdminPages>> GetParentList()
        {
            return await _context.AdminPages.Where(s => s.ParentId == 0).ToListAsync();
        }
        public async Task<IList<Products>> GeProductList()
        {
            return await _context.Products.Where(x => x.IsDeleted != true && x.IsPublish == true).ToListAsync();
             
        }
      
        public async Task<IList<AspNetUsers>> GetCustomerList()
        {
            return await _context.AspNetUsers.Where(s=> s.AspNetUserRoles.Where(g=> g.RoleId == "2").Any()).ToListAsync().ConfigureAwait(false);
        }
    }
}
