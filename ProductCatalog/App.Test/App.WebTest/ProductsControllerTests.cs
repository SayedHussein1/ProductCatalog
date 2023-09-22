using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using App.Admin.Controllers;
using App.Application.Interfaces;
using App.Application.Model;
using System.Threading.Tasks;

public class ProductsControllerTests
{
    [Fact]
    public async Task AddEdit_Get_ReturnsView()
    {
        // Arrange
        var productId = 1;
        var mockProductsService = new Mock<IProductsSevices>();
        mockProductsService.Setup(service => service.GetById(productId))
            .ReturnsAsync(new ProductsModel { Id = productId });

        var controller = new ProductsController(mockProductsService.Object, null, null,null);

        // Act
        var result = await controller.AddEdit(productId);

        // Assert
        Assert.IsType<ViewResult>(result);
    }

    [Fact]
    public async Task AddEdit_Post_ValidModel_ReturnsRedirectToAction()
    {
        // Arrange
        var productsModel = new ProductsModel { Id = 1 };
        var mockProductsService = new Mock<IProductsSevices>();
        mockProductsService.Setup(service => service.Save(productsModel))
            .ReturnsAsync(true);

        var controller = new ProductsController(mockProductsService.Object, null, null, null);

        // Act
        var result = await controller.AddEdit(productsModel);

        // Assert
        var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
        Assert.Equal("Index", redirectToActionResult.ActionName);
    }

    [Fact]
    public async Task Delete_Post_ValidId_ReturnsJsonResult()
    {
        // Arrange
        var productId = 1;
        var mockProductsService = new Mock<IProductsSevices>();
        mockProductsService.Setup(service => service.Delete(productId))
            .ReturnsAsync(true);

        var controller = new ProductsController(mockProductsService.Object, null, null, null);

        // Act
        var result = await controller.Delete(productId);

        // Assert
        var jsonResult = Assert.IsType<JsonResult>(result);
        Assert.True((bool)jsonResult.Value);
    }

    [Fact]
    public async Task Status_Post_ValidIdAndStatus_ReturnsJsonResult()
    {
        // Arrange
        var productId = 1;
        var status = true;
        var mockProductsService = new Mock<IProductsSevices>();
        mockProductsService.Setup(service => service.ChangeStatus(productId, status))
            .ReturnsAsync(true);

        var controller = new ProductsController(mockProductsService.Object, null, null, null);

        // Act
        var result = await controller.Status(productId, status);

        // Assert
        var jsonResult = Assert.IsType<JsonResult>(result);
        Assert.True((bool)jsonResult.Value);
    }

}
