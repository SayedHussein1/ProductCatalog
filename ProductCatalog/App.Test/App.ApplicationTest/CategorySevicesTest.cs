using App.Application.Interfaces;
using App.Application.Model;
using App.Application.Services;
using App.Domain.Interfaces;
using App.Domain.Model;
using AutoMapper;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace App.Test.App.ApplicationTest
{
    public class CategorySevicesTest
    {
        [Fact]
        public async Task GetById_Returns_CategoryModel()
        {
            // Arrange
            int categoryId = 1;
            var mockCategoryRepository = new Mock<ICategoryRepository>();
            var mockLanguageServices = new Mock<ILanguageSevices>();
            var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
            var mockLocalizedModelFactory = new Mock<ILocalizedModelFactory>();
            var mockAttachmentService = new Mock<IAttachmentService>();

            var category = new Category { Id = categoryId, Name = "TestCategory" };
            mockCategoryRepository.Setup(repo => repo.GetItemById(categoryId)).ReturnsAsync(category);

            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryModel>());
            IMapper mapper = mapperConfig.CreateMapper();

            var categoryServices = new CategorySevices(
                mockCategoryRepository.Object,
                mapper,
                mockLanguageServices.Object,
                mockHttpContextAccessor.Object,
                mockAttachmentService.Object,
                mockLocalizedModelFactory.Object
            );

            // Act
            var result = await categoryServices.GetById(categoryId);

            // Assert
            result.Should().NotBeNull();
            result.Id.Should().Be(categoryId);
            result.Name.Should().Be(category.Name);
        }

        [Fact]
        public async Task Save_Updates_Category()
        {
            // Arrange
            int categoryId = 1;
            var categoryModel = new CategoryModel { Id = categoryId, Name = "UpdatedCategory" };
            var mockCategoryRepository = new Mock<ICategoryRepository>();
            var mockLanguageServices = new Mock<ILanguageSevices>();
            var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
            var mockLocalizedModelFactory = new Mock<ILocalizedModelFactory>();
            var mockAttachmentService = new Mock<IAttachmentService>();

            var categoryServices = new CategorySevices(
                mockCategoryRepository.Object,
                new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CategoryModel, Category>())),
                mockLanguageServices.Object,
                mockHttpContextAccessor.Object,
                mockAttachmentService.Object,
                mockLocalizedModelFactory.Object
            );

            // Act
            await categoryServices.Save(categoryModel);

            // Assert
            mockCategoryRepository.Verify(repo => repo.SaveItem(It.Is<Category>(c => c.Id == categoryId && c.Name == categoryModel.Name)), Times.Once());
        }
    }
}
