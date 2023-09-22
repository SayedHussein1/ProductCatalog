using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using App.Admin.Controllers;
using App.Application.Interfaces;
using App.Application.Model;
using System.Threading.Tasks;

public class CategoryControllerTests
{
    [Fact]
    public async Task AddEdit_Get_ReturnsView()
    {
        // Arrange
        var categoryId = 1;
        var mockCategoryService = new Mock<ICategorySevices>();
        mockCategoryService.Setup(service => service.GetById(categoryId))
            .ReturnsAsync(new CategoryModel { Id = categoryId });

        var controller = new CategoryController(mockCategoryService.Object, null, null);

        // Act
        var result = await controller.AddEdit(categoryId);

        // Assert
        Assert.IsType<ViewResult>(result);
    }

    [Fact]
    public async Task AddEdit_Post_ValidModel_ReturnsRedirectToAction()
    {
        // Arrange
        var categoryModel = new CategoryModel { Id = 1 };
        var mockCategoryService = new Mock<ICategorySevices>();
        mockCategoryService.Setup(service => service.Save(categoryModel));
          

        var controller = new CategoryController(mockCategoryService.Object, null, null);

        // Act
        var result = await controller.AddEdit(categoryModel);

        // Assert
        var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
        Assert.Equal("Index", redirectToActionResult.ActionName);
    }

    [Fact]
    public async Task Delete_Post_ValidId_ReturnsJsonResult()
    {
        // Arrange
        var categoryId = 1;
        var mockCategoryService = new Mock<ICategorySevices>();
        mockCategoryService.Setup(service => service.Delete(categoryId))
            .ReturnsAsync(true);

        var controller = new CategoryController(mockCategoryService.Object, null, null);

        // Act
        var result = await controller.Delete(categoryId);

        // Assert
        var jsonResult = Assert.IsType<JsonResult>(result);
        Assert.True((bool)jsonResult.Value);
    }

}
