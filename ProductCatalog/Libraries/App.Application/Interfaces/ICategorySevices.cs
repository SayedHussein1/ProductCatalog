﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using App.Application.ViewModels;
 
using App.Application.Model;
using System.Threading.Tasks;
using System;

namespace App.Application.Interfaces
{
    public interface ICategorySevices
    {
        Task<CategoryModel>  GetById(int id);
        Task Save(CategoryModel model);
        Task<bool> ChangeStatus(int id, bool status);
          Task<bool> Delete(int id);
        Task<Tuple<IList<CategoryViewModel>, int>> LoadData(string Search = null, int StatusId = 0, DateTime? StartDate = null, DateTime? EndDate = null,
           int jtStartIndex = 0, int jtPageSize = 10, string order = null, string orderDir = null);
       
    }
}