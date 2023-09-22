using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using App.Application.ViewModels;
 
using App.Application.Model;
using System.Threading.Tasks;
using System;

namespace App.Application.Interfaces
{
    public interface IProductsSevices
    {
        Task<ProductsModel>  GetById(int id);
        Task<bool> Save(ProductsModel model);
        Task<bool> ChangeStatus(int id, bool status);
          Task<bool> Delete(int id);
        Task<Tuple<IList<ProductsViewModel>, int>> LoadData(  string Search = null, int StatusId = 0, int CategoryId = 0,int SubCategoryId = 0,
           int jtStartIndex = 0, int jtPageSize = 10, string order = null, string orderDir = null);

        IList<ProductsViewModel> LoadDataForHomePage(bool isAdmin, int CategoryId = 0);
    }
}