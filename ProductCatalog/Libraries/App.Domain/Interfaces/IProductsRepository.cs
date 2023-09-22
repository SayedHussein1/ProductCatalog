using App.Domain.Model;
 
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Interfaces
{
    public interface IProductsRepository
    {
        Task<bool> ChangeStatusItem(int id, bool status);
        Task<bool> DeleteItem(int id);
        Task<Products>  GetItemById(int id);  
        Task<Products>  GetProductById(int id);
        Task<Tuple<IList<Products>, int>> LoadItemsData(string Search, int StatusId, int CategoryId,int SubCategoryId, int jtStartIndex = 0,
            int jtPageSize = 10, string order = null, string orderDir = null);

        Task SaveItem(Products obj);

        IList<Products> LoadDataForHomePage(int CategoryId, bool isAdmin);
    }
}
