using App.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Interfaces
{
    public interface IUserRepository
    {
    //    Task AddNotification(Notification obj);
        Task<AspNetUsers> GetUserById(string userId);
        Task UpdateCustomerToken(string id, string token);
        Task UpdateCustomerPicture(string id, int pictureId);
        Task<AspNetUsers> GetUserByEmail(string userId);
        Task<string> GetAllFullNameUsersByIds(string[] userIds);
        Task<IList<AdminPages>> GeAdminPagesList(string[] roleNames);
        Task<Tuple<IList<AspNetUsers>,int>> LoadItemsData(string email, string fullName, string phoneNumber, string roleName, int StatusId,  int jtStartIndex = 0,
         int jtPageSize = 10, string order = null, string orderDir = null);


   


    }
}
