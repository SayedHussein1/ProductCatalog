using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using App.Application.ViewModels;
using App.Application.Model;
using System.Threading.Tasks;

namespace App.Application.Interfaces
{
    public interface ILookupSevices
    {
        Task<IList<BaseViewModel>> GetParentList(string selectTitle = null);
        Task<IList<BaseViewModel>> GeProductList(string selectTitle = null);
        Task<IList<BaseViewModel>> GetCustomerList(string selectTitle = null);

    }
}