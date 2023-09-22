using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using App.Application.Interfaces;
using App.Application.Model;
using App.Domain.Interfaces;
using System.Threading.Tasks;

namespace App.Application.Services
{

    public class InitalizeModelLookups : IInitalizeModelLookups
    {
        private readonly ILookupSevices _lookupSevices;
        private readonly IGroupService _groupService;
        private readonly IHttpContextAccessor _httpContextAccessor;
       
        public InitalizeModelLookups(ILookupSevices lookupSevices, 
            IHttpContextAccessor httpContextAccessor,
             IGroupService groupService,
             IUserRepository userRepository)
        {
            _lookupSevices = lookupSevices;
            _groupService = groupService;
            _httpContextAccessor = httpContextAccessor;
        }
      
        public async Task InitModel(AdminPagesModel model, string selectTitle = null)
        {
            model.ParentList = new SelectList(await _lookupSevices.GetParentList(selectTitle), "Id", "Name");
        } 
      
      
        public async Task InitModel(GroupModel model, string selectTitle = null)
        {
            model.AdminPagesList = new SelectList(await _groupService.GeAdminPagesList(selectTitle), "Id", "Name");
        }
        public async Task InitModel(UserModel model, string selectTitle = null)
        {
            model.RolesList = new SelectList(await _groupService.GeRolesList(selectTitle), "IdString", "Name");
        }
       
        public async Task InitModel(ProductsModel model, string selectTitle = null)
        {
            model.CategoryList = new SelectList(await _groupService.GeCategoryList(selectTitle), "Id", "Name", model.CategoryId);
        }

        public async Task InitModel(HomePageModel model, string selectTitle = null)
        {
            model.CategoryList = new SelectList(await _groupService.GeCategoryList(selectTitle), "Id", "Name", model.CategoryId);

        }
    }
}