using App.Application.Model;
using App.Application.Models;
using App.Application.ViewModels;
using App.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Interfaces
{
    public interface IUsersService
    {
        Task<string> SignInAsync(string userName, string password, bool isPersistent,bool loginFromPortal = false,string returnUrl = null);
        Task<string> SignInWebAsync(string userName, string password, bool isPersistent,bool loginFromPortal = false,string returnUrl = null);
        Task<UserModel> GetUserById(string userId);
        Task UpdateCustomerToken(string token);
        Task UpdateCustomerPicture(int pictureId);
        Task ChangeStatus(string userId, bool status);
        Task<string> CreateUpdateAsync(UserModel model);
        Task SignOutAsync();
        Task<string> ChangePasswordAsync(string currentPassword, string newPassword);
        Task<string> RestPasswordAsync(string userId, string newPassword);
        Task<bool> CheckUserAccessPage(string page);
        Task<IList<AdminPagesViewModel>> GetUserAccessPages();
        Task<string> ForgotPasswordAsync(string email,bool forgertFromPortal = false);
        Task<string> ForgotPasswordMobileAsync(string email, bool forgertFromPortal = false);
        Task<string> ResetPasswordAsync(string email,string password,string code);
        Task<bool> ConfirmEmailAsync(string userId,string code);
        Task<Tuple<IList<UserViewModel>,int>> LoadData(string email, string fullName, string phoneNumber, string roleName,int StatusId, int jtStartIndex = 0,
             int jtPageSize = 10, string order = null, string orderDir = null);
       
    }
}
