﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using App.Application.FrameWork;
using App.Application.Interfaces;
using App.Application.ViewModels;
using App.Domain.Interfaces;

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
using App.Application.Framwork;

namespace App.Application.Services
{
    public class CategorySevices : ICategorySevices
    {
        public readonly ICategoryRepository _CategoryRepository;
        private readonly IMapper _mapper;
        private readonly ILanguageSevices _languageSevices;
        public readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILocalizedModelFactory _localizedModelFactory;
        private readonly IAttachmentService _attachmentService;
        public CategorySevices(ICategoryRepository CategoryRepository,
             IMapper mapper
            , ILanguageSevices languageSevices, 
            IHttpContextAccessor httpContextAccessor, 
            IAttachmentService attachmentService,
            ILocalizedModelFactory localizedModelFactory)
        {
            _CategoryRepository = CategoryRepository;
            _languageSevices = languageSevices;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _localizedModelFactory = localizedModelFactory;
            _attachmentService = attachmentService;
        }
        public async Task<CategoryModel>  GetById(int id)
        {
            var obj = new Category();
            if (id > 0)
                obj = await _CategoryRepository.GetItemById(id);

            var model = _mapper.Map<CategoryModel>(obj);
            Action<CategoryLocalizedModel, int> localizedModelConfiguration = null;
            localizedModelConfiguration = (locale, languageId) =>
            {
                locale.Name = _languageSevices.GetLocalized(obj, entity => entity.Name, languageId, false, false).Result;
            };
            model.Locales =await _localizedModelFactory.PrepareLocalizedModels(localizedModelConfiguration);

            return model;
        }
        public async Task Save(CategoryModel model)
        {
            var obj = new Category();
            if (model.Id > 0)
                obj = await _CategoryRepository.GetItemById(model.Id);
            else
            {
                obj.CreateBy = _httpContextAccessor.HttpContext.User.GetId();
                obj.CreateDate = DateTime.Now.ReternLocalDate();
            }
            _mapper.Map(model, obj);

            obj.UpdateBy = _httpContextAccessor.HttpContext.User.GetId();
            obj.UpdateDate = DateTime.Now.ReternLocalDate();

            await _CategoryRepository.SaveItem(obj);

            await UpdateLocales(obj, model);
        }
        public async Task<bool> ChangeStatus(int id, bool status)
        {
            return await _CategoryRepository.ChangeStatusItem(id, status);
        }
        public async Task<bool> Delete(int id)
        {
            return await _CategoryRepository.DeleteItem(id);
        }

        public async Task<Tuple<IList<CategoryViewModel>, int>> LoadData(string Search = null, int StatusId = 0,DateTime? StartDate = null, DateTime? EndDate = null,
           int jtStartIndex = 0, int jtPageSize = 10, string order = null, string orderDir = null)
        {
            var data = await _CategoryRepository.LoadItemsData(Search, StatusId,StartDate, EndDate,
               jtStartIndex, jtPageSize, order, orderDir);

            var list = await data.Item1.SelectAwait(async obj =>
            {
                var model = _mapper.Map<CategoryViewModel>(obj);
                model.IconUrl = await _attachmentService.GetPictureUrlApi(obj.IconId);
                model.Name = await _languageSevices.GetLocalized(obj, entity => entity.Name);
                return model;
            }).ToListAsync();

            return new Tuple<IList<CategoryViewModel>, int>(list, data.Item2);
        }
        public async Task UpdateLocales(Category Category, CategoryModel model)
        {
            foreach (var localized in model.Locales)
            {
              await  _languageSevices.SaveLocalizedValue(Category,
                     x => x.Name,
                     localized.Name,
                     localized.LanguageId);
            }
        }
    }
}
