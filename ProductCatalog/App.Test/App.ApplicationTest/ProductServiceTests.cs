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
    public class ProductServiceTests
    {
        [Fact]
        public async Task GetById_Returns_ProductsModel()
        {
            // Arrange
            int productId = 1;
            var mockProductsRepository = new Mock<IProductsRepository>();
            var mockLanguageServices = new Mock<ILanguageSevices>();
            var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
            var mockLocalizedModelFactory = new Mock<ILocalizedModelFactory>();
            var mockAttachmentService = new Mock<IAttachmentService>();
            var mockLocaleStringResourceServices = new Mock<ILocaleStringResourceSevices>();

            var product = new Products { Id = productId, Title = "TestProduct" };
            mockProductsRepository.Setup(repo => repo.GetItemById(productId)).ReturnsAsync(product);

            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<Products, ProductsModel>());
            IMapper mapper = mapperConfig.CreateMapper();

            var productsServices = new ProductsSevices(
                mockProductsRepository.Object,
                mapper,
                mockLanguageServices.Object,
                mockAttachmentService.Object,
                mockHttpContextAccessor.Object,
                mockLocalizedModelFactory.Object,
                mockLocaleStringResourceServices.Object
            );

            // Act
            var result = await productsServices.GetById(productId);

            // Assert
            result.Should().NotBeNull();
            result.Id.Should().Be(productId);
            result.Title.Should().Be(product.Title);
        }

        [Fact]
        public async Task Save_Updates_Product()
        {
            // Arrange
            int productId = 1;
            var productModel = new ProductsModel { Id = productId, Title = "UpdatedProduct" , CategoryId = 1 };
            var mockProductsRepository = new Mock<IProductsRepository>();
            var mockLanguageServices = new Mock<ILanguageSevices>();
            var mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
            var mockLocalizedModelFactory = new Mock<ILocalizedModelFactory>();
            var mockAttachmentService = new Mock<IAttachmentService>();
            var mockLocaleStringResourceServices = new Mock<ILocaleStringResourceSevices>();

            var productsServices = new ProductsSevices(
                mockProductsRepository.Object,
                new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ProductsModel, Products>())),
                mockLanguageServices.Object,
                mockAttachmentService.Object,
                mockHttpContextAccessor.Object,
                mockLocalizedModelFactory.Object,
                mockLocaleStringResourceServices.Object
            );

            // Act
            var result = await productsServices.Save(productModel);

            // Assert
            result.Should().BeTrue();
            mockProductsRepository.Verify(repo => repo.SaveItem(It.Is<Products>(p => p.Id == productId && p.Title == productModel.Title)), Times.Once());
        }
    }
}
