using App.Domain.Model;
 
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<bool> ChangeStatusItem(int id, bool status);
        Task<bool> DeleteItem(int id);
        Task<Category>  GetItemById(int id);  
        Task<Tuple<IList<Category>, int>> LoadItemsData(string Search, int StatusId,  DateTime? StartDate, DateTime? EndDate, int jtStartIndex = 0,
            int jtPageSize = 10, string order = null, string orderDir = null);
        Task SaveItem(Category obj);
    }
}
