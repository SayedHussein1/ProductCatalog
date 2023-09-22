using App.Application.Caching;
using App.Application.Framwork;
using App.Application.Interfaces;
using App.Application.Model;
using App.Application.Services;
using App.Application.Validator;
using App.Domain.Interfaces;
using App.Infra.Data.Repositories;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace App.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Repository
          
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ILanguageRepository, LanguageRepository>();
            services.AddScoped<IAttachmentRepository, AttachmentRepository>();
            services.AddScoped<IAdminPagesRepository, AdminPagesRepository>();
            services.AddScoped<ILookupRepository, LookupRepository>();
            services.AddScoped<IGroupRepository, GroupRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ILocaleStringResourceRepository, LocaleStringResourceRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductsRepository, ProductsRepository>();
            //Sevices
          
            services.AddScoped<ICategorySevices, CategorySevices>();
            services.AddScoped<ILanguageSevices, LanguageSevices>();
            services.AddScoped<IAttachmentService, AttachmentService>();
            services.AddScoped<IAdminPagesSevices, AdminPagesSevices>();
            services.AddScoped<ILocalizedModelFactory, LocalizedModelFactory>();
            services.AddScoped<ILookupSevices, LookupSevices>();
            services.AddScoped<IInitalizeModelLookups, InitalizeModelLookups>();
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<ILocaleStringResourceSevices, LocaleStringResourceSevices>();
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<IProductsSevices, ProductsSevices>();

            //Validator
           
            services.AddTransient<IValidator<CategoryModel>, CategoryValidator>();
            services.AddTransient<IValidator<ProductsModel>, ProductsValidator>();
            services.AddTransient<IValidator<UserModel>, UserValidator>();
            services.AddTransient<IValidator<LanguageModel>, LanguageValidator>();
            services.AddTransient<IValidator<LocaleStringResourceModel>, LocaleStringResourceValidator>();


            services.AddScoped<ICacheManager, MemoryCacheManager>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
