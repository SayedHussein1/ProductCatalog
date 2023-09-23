using App.Admin.Controllers;
using App.Application.FrameWork;
using App.Application.Interfaces;
using App.Application.Model;
using App.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace App.Admin.Controllers
{
    public class ProductsController : BaseController
    {
 
        private readonly IProductsSevices _productsSevices;
        private readonly IInitalizeModelLookups _initalizeModelLookups;
        private readonly ILocaleStringResourceSevices _localeStringResourceSevices;
        private readonly ILogger<ProductsController> _logger;   
        
        public ProductsController(IProductsSevices productsSevices,
            IInitalizeModelLookups initalizeModelLookups, ILocaleStringResourceSevices localeStringResourceSevices , ILogger<ProductsController> logger)
        {
            _productsSevices = productsSevices;
            _localeStringResourceSevices = localeStringResourceSevices;
            _initalizeModelLookups = initalizeModelLookups;
            _logger = logger;   
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new ProductsModel();

                await _initalizeModelLookups.InitModel(model, _localeStringResourceSevices.GetResource("All"));

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred in the ProductsController Index action.");
                return View("Error"); 
            }
        }

        public async Task<IActionResult> AddEdit(int id = 0)
        {
            var model = await _productsSevices.GetById(id);


            if (model == null)
            {
                _logger.LogInformation("An error occurred in the ProductsController AddEdit action , Product not exist");

                return RedirectToAction("Index");

            }
            await _initalizeModelLookups.InitModel(model, _localeStringResourceSevices.GetResource("Select"));



            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> AddEdit(ProductsModel model)
        {
            try
            {
                var result = await _productsSevices.Save(model);
                if (result)
                {
                    TempData["successMsg"] = _localeStringResourceSevices.GetResource("SuccessfullyMsg");
                    return RedirectToAction("Index", "Products");
                }
                else
                {
                    TempData["errorMsg"] = _localeStringResourceSevices.GetResource("thereforbiddenWords");
                    await _initalizeModelLookups.InitModel(model, _localeStringResourceSevices.GetResource("Select"));
                }
            }
            catch (Exception ex)
            {
                 _logger.LogInformation(ex.Message, "An error occurred in the ProductsController AddEdit post Action .");
             
            }

            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var result =await _productsSevices.Delete(id);
            return Json(result);
        }
        [HttpPost]
        public async Task<IActionResult> Status(int id, bool status)
        {
            try
            {
                var result = await _productsSevices.ChangeStatus(id, status);
                return Json(result);
            }
            catch (Exception ex)
            {
                 _logger.LogInformation(ex.Message, "An error occurred in the ProductsController Status action .");
                return Json(new { error = 1, message = ex.Message });
            }
           
        }
     
        public async Task<JsonResult> LoadData(string Search,int StatusId, int CategoryId, int SubCategoryId)
        {   
            // Initialization.
           // string Search = HttpContext.Request.Form["search[value]"][0];
            string draw = HttpContext.Request.Form["draw"][0];
            string order = HttpContext.Request.Form["order[0][column]"][0];
            string orderDir = HttpContext.Request.Form["order[0][dir]"][0];
            int startRec = Convert.ToInt32(HttpContext.Request.Form["start"][0]);
            int pageSize = Convert.ToInt32(HttpContext.Request.Form["length"][0]);
            // Total record count.
           // int totalRecords;
            // Loading.
            var data =await _productsSevices.LoadData( Search, StatusId, CategoryId, SubCategoryId,  startRec,
                pageSize, order, orderDir) ;
            
            return Json(new
            {
                draw = Convert.ToInt32(draw),
                recordsTotal = data.Item2,
                recordsFiltered = data.Item2,
                data = data.Item1
            });
        }

        public IActionResult GetProducts(int categoryId)
        {
            var loggedUserIsAdmin = User.IsInRole("Administrator");

            var data = _productsSevices.LoadDataForHomePage(loggedUserIsAdmin, categoryId);

            return Json(data);
        }


    }
}
