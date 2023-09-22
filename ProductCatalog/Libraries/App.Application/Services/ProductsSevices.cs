using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using App.Application.FrameWork;
using App.Application.Interfaces;
using App.Application.ViewModels;
using App.Domain.Interfaces;
using App.Application.Framwork;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using AutoMapper;
using App.Application.Model;
using App.Domain.Model;
using Microsoft.AspNetCore.Http;

namespace App.Application.Services
{
    public class ProductsSevices : IProductsSevices
    {
        
        public readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;
        private readonly ILanguageSevices _languageSevices;
        public readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILocalizedModelFactory _localizedModelFactory;
        private readonly IAttachmentService _attachmentService;
        private readonly ILocaleStringResourceSevices _localeStringResourceSevices;

        public ProductsSevices(IProductsRepository productsRepository, 
             IMapper mapper, ILanguageSevices languageSevices,
               IAttachmentService attachmentService,
             IHttpContextAccessor httpContextAccessor,ILocalizedModelFactory localizedModelFactory, ILocaleStringResourceSevices localeStringResourceSevices)
        {
            _productsRepository = productsRepository;
            _attachmentService = attachmentService;
            _languageSevices = languageSevices;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
           _localeStringResourceSevices = localeStringResourceSevices;  
            _localizedModelFactory = localizedModelFactory;
        }
        public async Task<ProductsModel>  GetById(int id)
        {
            var obj = new Products();
            if (id > 0)
                  obj = await _productsRepository.GetItemById(id);
           
            var model = _mapper.Map<ProductsModel>(obj);

            Action<ProductsLocalizedModel, int> localizedModelConfiguration = null;
            localizedModelConfiguration = async (locale, languageId) =>
            {
                locale.Title = await _languageSevices.GetLocalized(obj, entity => entity.Title, languageId, false, false);
                locale.FullDescription = await _languageSevices.GetLocalized(obj, entity => entity.FullDescription, languageId, false, false);
                locale.ShortDescription = await _languageSevices.GetLocalized(obj, entity => entity.ShortDescription, languageId, false, false);
            };
            model.Locales = await _localizedModelFactory.PrepareLocalizedModels(localizedModelConfiguration);
         
            model.SwitchCategoryList = obj.SwitchMapping.Select(item => new SwitchMappingModel()
            {
                CategoryId = item.CategoryId ?? 0,
            }).ToList();

            model.ListImages = await obj.ProductImage
             .SelectAwait(async s =>
             {
                 var file = await _attachmentService.GetPictureDataFromCache(s.ImageId);
                 file.tableId = s.Id;
                 return file;
             }).ToListAsync();
            return model;
        }
     
        public async Task<bool> Save(ProductsModel model)
        {
            var obj = new Products();

            if (model.Id > 0) 
                obj = await _productsRepository.GetItemById(model.Id);
            else
            {
                obj.CreateByUserId = _httpContextAccessor.HttpContext.User.GetId();
                obj.CreateDate = DateTime.Now.ReternLocalDate();
            }
            _mapper.Map(model, obj);

            var list = model.SwitchCategoryList.Select(item => new SwitchMapping()
            {
                ProductId = obj.Id,
                CategoryId = item.CategoryId,
            }).ToList();

            obj.SwitchMapping = list;

            var listAttachments = new List<ProductImage>();

            if (model.ListImages != null)
            {
                listAttachments.AddRange(model.ListImages.Where(g => g.deleted != true)
                    .Select(g => new ProductImage()
                    {
                        ImageId = g.id ?? 0,
                        ProductId = obj.Id,
                    }).ToList());

                obj.ProductImage = listAttachments;
                obj.ImageId = listAttachments.Any() ? listAttachments.FirstOrDefault().ImageId : 0;
            }

            

            await _productsRepository.SaveItem(obj);

            await UpdateLocales(obj, model);

            return true;
        }
        public async Task<bool> ChangeStatus(int id, bool status)
        {
            return await _productsRepository.ChangeStatusItem(id, status);
        }
        public async Task<bool> Delete(int id)
        {
            return await _productsRepository.DeleteItem(id);
        }

        public async Task<Tuple<IList<ProductsViewModel>, int>> LoadData(string Search = null, int StatusId = 0, int CategoryId = 0,int SubCategoryId = 0,
           int jtStartIndex = 0, int jtPageSize = 10, string order = null, string orderDir = null)
        {
            var data = await _productsRepository.LoadItemsData(Search, StatusId, CategoryId, SubCategoryId,
               jtStartIndex, jtPageSize, order, orderDir);

            var list = await data.Item1.SelectAwait(async obj =>
            {
                var model = _mapper.Map<ProductsViewModel>(obj);
                model.Title = await _languageSevices.GetLocalized(obj, entity => entity.Title);

                if (obj.Category != null)
                {
                    model.CategoryName = await _languageSevices.GetLocalized(obj.Category, entity => entity.Name);
                } 
              
                if (obj.CreateByUser != null)
                {
                    model.CreateByUserName = obj.CreateByUser.FullName;
                }

                model.Price = $"{obj.Price} {_localeStringResourceSevices.GetResource("EGP")}";

                model.Duration = $"{obj.Duration} {_localeStringResourceSevices.GetResource("day")}";

                model.StartDate = obj.StartDate.ToString("dd/MM/yyyy hh:mm tt");


                if (obj.CreateByUser != null)
                {
                    model.CreateByUserName = obj.CreateByUser.FullName;
                }
                model.CreateDateMonth = obj.CreateDate.ToString("dd/MM/yyyy hh:mm tt");
                return model;
            }).ToListAsync();
            return new Tuple<IList<ProductsViewModel>, int>(list, data.Item2);
        }
 
      
      
        public async Task UpdateLocales(Products Products, ProductsModel model)
        {
            foreach (var localized in model.Locales)
            {
                await _languageSevices.SaveLocalizedValue(Products,
                     x => x.Title,
                     localized.Title,
                     localized.LanguageId);
                await _languageSevices.SaveLocalizedValue(Products,
                     x => x.ShortDescription,
                     localized.ShortDescription,
                     localized.LanguageId);
                await _languageSevices.SaveLocalizedValue(Products,
                 x => x.FullDescription,
                 localized.FullDescription,
                 localized.LanguageId);
            }
        }



        public IList<ProductsViewModel> LoadDataForHomePage( bool isAdmin , int CategoryId = 0)
        {
            var data =  _productsRepository.LoadDataForHomePage(CategoryId ,  isAdmin);

            var list =  data.Select( obj =>
            {
                var model = _mapper.Map<ProductsViewModel>(obj);
                model.Title =  _languageSevices.GetLocalized(obj, entity => entity.Title).Result;

                if (obj.Category != null)
                {
                    model.CategoryName =  _languageSevices.GetLocalized(obj.Category, entity => entity.Name).Result;
                }

                if (obj.CreateByUser != null)
                {
                    model.CreateByUserName = obj.CreateByUser.FullName;
                }

                model.Price = $"{obj.Price} {_localeStringResourceSevices.GetResource("EGP")}";

                model.Duration = $"{obj.Duration} {_localeStringResourceSevices.GetResource("day")}";

                model.StartDate = obj.StartDate.ToString("dd/MM/yyyy hh:mm tt");

                if (obj.ImageId > 0)
                {
                    var url =  _attachmentService.GetPictureUrlNotCached(obj.ImageId).Result;

                   model.ImageUrl = url;    

                }
                if (obj.CreateByUser != null)
                {
                    model.CreateByUserName = obj.CreateByUser.FullName;
                }
                model.CreateDateMonth = obj.CreateDate.ToString("dd/MM/yyyy hh:mm tt");
                return model;

            }).ToList();

            return list;
        }

      
    }
}
