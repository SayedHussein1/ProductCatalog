using App.Application.Model;
using App.Application.ViewModels;
using App.Domain.Model;
using AutoMapper;


namespace App.Application.Framwork
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //AdminPages
            CreateMap<AdminPages, AdminPagesModel>();

            CreateMap<AdminPages, AdminPagesViewModel>();

            CreateMap<AdminPagesModel, AdminPages>();

         

            //AspNetRoles
            CreateMap<AspNetRoles, GroupModel>();
            CreateMap<AspNetRoles, GroupViewModel>();

            CreateMap<GroupModel, AspNetRoles>();

            //Language
            CreateMap<Language, LanguageModel>();

            CreateMap<Language, LanguageViewModel>();

            CreateMap<LanguageModel, Language>();
           
            CreateMap<Category, CategoryModel>();

            CreateMap<Category, CategoryViewModel>();

            CreateMap<CategoryModel, Category>()
                 .ForMember(dest => dest.CreateBy, mo => mo.Ignore())
                 .ForMember(dest => dest.CreateDate, mo => mo.Ignore());
           // Products
            CreateMap<Products, ProductsModel>();

            CreateMap<Products, ProductsViewModel>();

            CreateMap<ProductsModel, Products>()
                 .ForMember(dest => dest.CreateByUserId, mo => mo.Ignore())
                 .ForMember(dest => dest.CreateDate, mo => mo.Ignore());

       
            CreateMap<LocaleStringResource, LocaleStringResourceModel>();

            CreateMap<LocaleStringResource, LocaleStringResourceViewModel>();

            CreateMap<LocaleStringResourceModel, LocaleStringResource>();

            //AspNetUsers
            CreateMap<UserModel, ApplicationUser>()
                .ForMember(dest => dest.PasswordHash, mo => mo.Ignore())
                .ForMember(dest => dest.SecurityStamp, mo => mo.Ignore())
                .ForMember(dest => dest.TwoFactorEnabled, mo => mo.Ignore())
                .ForMember(dest => dest.ConcurrencyStamp, mo => mo.Ignore())
                .ForMember(dest => dest.NormalizedEmail, mo => mo.Ignore())
                .ForMember(dest => dest.NormalizedUserName, mo => mo.Ignore())
                .ForMember(dest => dest.EmailConfirmed, mo => mo.Ignore())
                .ForMember(dest => dest.AccessFailedCount, mo => mo.Ignore())
                .ForMember(dest => dest.PhoneNumberConfirmed, mo => mo.Ignore());

            CreateMap<ApplicationUser, UserModel>()
               .ForMember(dest => dest.RoleName, mo => mo.Ignore())
               .ForMember(dest => dest.RolesList, mo => mo.Ignore())
               .ForMember(dest => dest.Password, mo => mo.Ignore())
               .ForMember(dest => dest.ConfirmPassword, mo => mo.Ignore());

            CreateMap<AspNetUsers, UserViewModel>()
               .ForMember(dest => dest.RoleName, mo => mo.Ignore());
        }
    }
}
