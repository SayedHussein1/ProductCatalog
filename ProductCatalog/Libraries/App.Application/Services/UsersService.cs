using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using App.Application.Caching;
using App.Application.FrameWork;
using App.Application.Interfaces;
using App.Application.Model;
using App.Application.ViewModels;
using App.Domain.Interfaces;
using App.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.WebUtilities;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Identity.UI.Services;

using App.Application.Framwork;
using App.Application.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace App.Application.Services
{
    public class UsersService : IUsersService
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ICacheManager _cacheManager;
        private readonly IUserRepository _userRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;
        private readonly ILocaleStringResourceSevices _localeStringResourceSevices;
        private readonly ILanguageSevices _languageSevices;
        private readonly IAttachmentService _attachmentService;
        public IConfiguration Configuration { get; }
        public UsersService(IUserRepository userRepository,
            ICacheManager cacheManager,
            SignInManager<ApplicationUser> signInManager,
             ILocaleStringResourceSevices localeStringResourceSevices,
            IEmailSender emailSender, ILanguageSevices languageSevices,
             UserManager<ApplicationUser> userManager,
            IHttpContextAccessor httpContextAccessor,
            IAttachmentService attachmentService,
               IConfiguration configuration,

            IMapper mapper)
        {
            _userRepository = userRepository;
            _cacheManager = cacheManager;
            _userManager = userManager;
            _signInManager = signInManager;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _emailSender = emailSender;
            _localeStringResourceSevices = localeStringResourceSevices;
            _languageSevices = languageSevices;
            _attachmentService = attachmentService;
            Configuration = configuration;
        }
        public async Task<string> SignInAsync(string userName, string password, bool isPersistent, bool loginFromPortal = false, string returnUrl = null)
        {
            var userInfo = await _userManager.FindByNameAsync(userName);
            if (userInfo == null)
                userInfo = await _userManager.FindByEmailAsync(userName);

            if (userInfo == null)
                return "NotFound";

            var result = await _signInManager.PasswordSignInAsync(userInfo.UserName, password, isPersistent, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return "Succeeded";
            }
            else if (result.RequiresTwoFactor)
                return "RequiresTwoFactor";
            else if (result.IsLockedOut)
                return "IsLockedOut";
            else
                return "NotFound";
        }
        public async Task<string> SignInWebAsync(string userName, string password, bool isPersistent, bool loginFromPortal = false, string returnUrl = null)
        {
            var userInfo = await _userManager.FindByNameAsync(userName);
            if (userInfo == null)
                userInfo = await _userManager.FindByEmailAsync(userName);

            if (userInfo == null)
                return "NotFound";

            var result = await _signInManager.PasswordSignInAsync(userInfo.UserName, password, isPersistent, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                if (!(await _userManager.IsInRoleAsync(userInfo, "Customers")))
                {
                    return "Succeeded";
                }
                return "NotFound";
            }
            else if (result.RequiresTwoFactor)
                return "RequiresTwoFactor";
            else if (result.IsLockedOut)
                return "IsLockedOut";
            else
                return "NotFound";
        }
        public async Task ChangeStatus(string id, bool status)
        {
            var identityUser = await _userManager.FindByIdAsync(id);
            var Result = await _userManager.SetLockoutEnabledAsync(identityUser, status);
        }
        public async Task UpdateCustomerToken(string token)
        {
            string userId = _httpContextAccessor.HttpContext.User.GetId();
            await _userRepository.UpdateCustomerToken(userId, token);
        }
        public async Task UpdateCustomerPicture(int pictureId)
        {
            string userId = _httpContextAccessor.HttpContext.User.GetId();
            await _userRepository.UpdateCustomerPicture(userId, pictureId);
        }
        public async Task<UserModel> GetUserById(string userId)
        {
            var obj = await _userManager.FindByIdAsync(userId);
            var objFullInfo = await _userRepository.GetUserById(userId);

            var model = _mapper.Map<UserModel>(obj);
            model.FullName = objFullInfo.FullName;

            var listRoles = await _userManager.GetRolesAsync(obj);

            if (listRoles.Any())
                model.RoleName = listRoles.FirstOrDefault();

            model.ProfileImage = obj.ProfileImageId > 0 ? await _attachmentService.GetPictureUrlApi(obj.ProfileImageId) : "profile.png";

            return model;
        }

        public async Task<UserViewModel> GetUserDataByEmail(string email)
        {
            var objFullInfo = await _userRepository.GetUserByEmail(email);

            var model = _mapper.Map<UserViewModel>(objFullInfo);

            if (objFullInfo.AspNetUserRoles.Any())
            {
                model.RoleName = objFullInfo.AspNetUserRoles.FirstOrDefault().Role.Name;
                model.IsMembers = objFullInfo.AspNetUserRoles.FirstOrDefault().Role.IsMembers;
                //    var listPages = GetUserAccessPages();
                //  model.IsPaymentAccess = listPages.Where(s => s.PageUrl == "Payment").Any();
            }
            return model;
        }
        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }
        public async Task<string> CreateUpdateAsync(UserModel model)
        {
            bool IsPhoneAlreadyRegistered = _userManager.Users.Any(item => item.PhoneNumber == model.PhoneNumber
            && item.Id != model.Id);
            if (IsPhoneAlreadyRegistered)
            {
                return "Phone number '" + model.PhoneNumber + "' is already taken.";
            }
            if (string.IsNullOrEmpty(model.Id))
            {
                var obj = new ApplicationUser();
                _mapper.Map(model, obj);

                obj.UserName = model.Email;
                obj.Address = model.Address;
                obj.NormalizedUserName = model.Email.ToUpper();
                obj.NormalizedEmail = model.Email.ToUpper();
                obj.EmailConfirmed = true;
                obj.PhoneNumberConfirmed = true;
                obj.CreateDate = DateTime.Now;
                obj.Id = Guid.NewGuid().ToString();
                var objuser = new AspNetUsers();

                var result = await _userManager.CreateAsync(obj, model.Password);

                if (!result.Succeeded)
                {
                    return string.Join("<br />", result.Errors.Select(s => s.Description));
                }
                else
                {
                    await _userManager.AddToRoleAsync(obj, model.RoleName);

                    await _userManager.SetLockoutEnabledAsync(obj, false);

                    return "Succeeded";
                }
            }
            else
            {
                var obj = await _userManager.FindByIdAsync(model.Id);

                _mapper.Map(model, obj);

                obj.UserName = model.Email;
                obj.Address = model.Address;
                obj.NormalizedUserName = model.Email.ToUpper();
                obj.NormalizedEmail = model.Email.ToUpper();

                var result = await _userManager.UpdateAsync(obj);

                if (!result.Succeeded)
                {
                    return string.Join("<br />", result.Errors.Select(s => s.Description));
                }
                else
                {
                    if (!string.IsNullOrEmpty(model.RoleName))
                    {
                        if (!await _userManager.IsInRoleAsync(obj, model.RoleName))
                        {
                            await _userManager.AddToRoleAsync(obj, model.RoleName);
                        }
                    }

                    return "Succeeded";
                }
            }
        }
        public async Task<string> ChangePasswordAsync(string currentPassword, string newPassword)
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);

            var changePasswordResult = await _userManager.ChangePasswordAsync(user, currentPassword, newPassword);
            if (changePasswordResult.Succeeded)
            {
                await _signInManager.RefreshSignInAsync(user);
                return "Succeeded";
            }
            else
            {
                return changePasswordResult.Errors.FirstOrDefault().Description;
            }
        }
        public async Task<string> RestPasswordAsync(string userId, string newPassword)
        {
            var user = new ApplicationUser();
            if (string.IsNullOrEmpty(userId))
            {
                user = _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User).Result;

                userId = user.Id;
            }
            user = await _userManager.FindByIdAsync(userId);

            await _userManager.RemovePasswordAsync(user);
            var changePasswordResult = await _userManager.AddPasswordAsync(user, newPassword);
            if (changePasswordResult.Succeeded)
            {
                return "Succeeded";
            }
            else
            {
                return changePasswordResult.Errors.FirstOrDefault().Description;
            }
        }
        public async Task<IList<AdminPagesViewModel>> GetUserAccessPages()
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);

            var roleNames = await _userManager.GetRolesAsync(user);

            var roleName = (roleNames).FirstOrDefault();

            var menuCacheKey = string.Format(ModelCacheEventConsumer.MENU_KEY, roleName, CommonHelper.WorkingLanguage.Id);

            return await _cacheManager.GetAsync(menuCacheKey, async () =>
            {
                var listLookup = await _userRepository.GeAdminPagesList(roleNames.ToArray());
                var result = await listLookup.SelectAwait(async obj =>
                {
                    var model = new AdminPagesViewModel();
                    model.PageTitle = await _languageSevices.GetLocalized(obj, entity => entity.PageTitle);
                    model.Id = obj.Id;
                    model.Icon = obj.Icon;
                    model.PageUrl = obj.PageUrl;
                    model.ParentId = obj.ParentId;
                    return model;
                }).ToListAsync();

                return result;
            });
        }
        public async Task<bool> CheckUserAccessPage(string page)
        {
            var listPages = await GetUserAccessPages();

            return listPages.Where(s => s.PageUrl == page).Any();
        }
        public async Task<string> ForgotPasswordAsync(string email, bool forgertFromPortal = false)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return "NotFound";

            var roleCheck = await _userManager.IsInRoleAsync(user, "PortalUsers");

            if (forgertFromPortal && !roleCheck)
                return "NotFound";
            else if (!forgertFromPortal && roleCheck)
                return "NotFound";

            if (!user.EmailConfirmed)
            {
                return "ForgotPasswordConfirmation";
            }

            // For more information on how to enable account confirmation and password reset please 
            // visit https://go.microsoft.com/fwlink/?LinkID=532713
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var callbackUrl = string.Format("{0}{1}{2}{3}",
                _httpContextAccessor.HttpContext.Request.Scheme + "://",
                _httpContextAccessor.HttpContext.Request.Host,
                "/Account/ResetPassword?code=",
                code);

            var body = "";
            //var templete = await _messagesTemplateRepository.GetMessagesTemplateById(2);
            var templete = string.Empty;

            body = templete;
            body = body.Replace("{Name}", user.FullName);
            body = body.Replace("{Url}", "<a href='" + HtmlEncoder.Default.Encode(callbackUrl) + "'>" + _localeStringResourceSevices.GetResource("clickHere") + "</a>.");

            await _emailSender.SendEmailAsync(email, _localeStringResourceSevices.GetResource("forgetPassword"), body);

            return "Succeeded";
        }
        public async Task<string> ForgotPasswordMobileAsync(string email, bool forgertFromPortal = false)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return "NotFound";

            var roleCheck = await _userManager.IsInRoleAsync(user, "PortalUsers");

            if (forgertFromPortal && !roleCheck)
                return "NotFound";
            else if (!forgertFromPortal && roleCheck)
                return "NotFound";

            if (!user.EmailConfirmed)
            {
                return "ForgotPasswordConfirmation";
            }

            // For more information on how to enable account confirmation and password reset please 
            // visit https://go.microsoft.com/fwlink/?LinkID=532713
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var callbackUrl = string.Format("{0}{1}{2}",
                Configuration["AdminUrl"], "/Account/ResetPassword?code=",
                code);

            var body = "";
            //var templete = await _messagesTemplateRepository.GetMessagesTemplateById(2);
            var templete = string.Empty;


            body = templete;
            body = body.Replace("{Name}", user.FullName);
            body = body.Replace("{Url}", "<a href='" + HtmlEncoder.Default.Encode(callbackUrl) + "'>" + _localeStringResourceSevices.GetResource("clickHere") + "</a>.");

            await _emailSender.SendEmailAsync(email, _localeStringResourceSevices.GetResource("forgetPassword"), body);

            return "Succeeded";
        }
        public async Task<string> ResetPasswordAsync(string email, string password, string code)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return "NotFound";
            }
            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var result = await _userManager.ResetPasswordAsync(user, code, password);
            if (result.Succeeded)
            {
                return "Succeeded";
            }
            var Errors = new List<string>();
            foreach (var error in result.Errors)
            {
                Errors.Add(error.Description);
            }
            return string.Join("<br />", Errors);
        }
        public async Task<bool> ConfirmEmailAsync(string userId, string code)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return false;
            }
            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                //   ChangeStatus(userId, false);
                return true;
            }

            return false;
        }
        public async Task<Tuple<IList<UserViewModel>, int>> LoadData(string email, string fullName, string phoneNumber, string roleName, int StatusId, int jtStartIndex = 0,
              int jtPageSize = 10, string order = null, string orderDir = null)
        {

            var data = await _userRepository.LoadItemsData(email, fullName, phoneNumber, roleName, StatusId, jtStartIndex,
                jtPageSize, order, orderDir);

            var list = data.Item1.Select(obj =>
            {
                var model = _mapper.Map<UserViewModel>(obj);

                var identityUser = _userManager.FindByIdAsync(obj.Id).Result;
                model.RoleName = _userManager.GetRolesAsync(identityUser).Result.FirstOrDefault();
                return model;
            });

            return new Tuple<IList<UserViewModel>, int>(list.ToList(), data.Item2);
        }

    }
}
