using App.Domain.Model;
 
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Interfaces
{
    public interface ILookupRepository
    {
        Task<IList<AdminPages>> GetParentList();
        Task<IList<Products>> GeProductList();
        Task<IList<AspNetUsers>> GetCustomerList();

    }
}
