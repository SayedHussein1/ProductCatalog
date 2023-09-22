using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using App.Admin.Controllers;
using App.Application.Interfaces;
using App.Application.Model;
using System.Threading.Tasks;

public class LanguageControllerTests
{
    [Fact]
    public async Task AddEdit_Get_ReturnsView()
    {
        // Arrange
        var languageId = 1;
        var mockLanguageService = new Mock<ILanguageSevices>();
        mockLanguageService.Setup(service => service.GetById(languageId))
            .ReturnsAsync(new LanguageModel { Id = languageId });

        var controller = new LanguageController(mockLanguageService.Object, null, null);

        // Act
        var result = await controller.AddEdit(languageId);

        // Assert
        Assert.IsType<ViewResult>(result);
    }

    [Fact]
    public async Task AddEdit_Post_ValidModel_ReturnsRedirectToAction()
    {
        // Arrange
        var languageModel = new LanguageModel { Id = 1 };
        var mockLanguageService = new Mock<ILanguageSevices>();
        mockLanguageService.Setup(service => service.Save(languageModel))
            .Returns(Task.CompletedTask);

        var controller = new LanguageController(mockLanguageService.Object, null, null);

        // Act
        var result = await controller.AddEdit(languageModel);

        // Assert
        var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
        Assert.Equal("Index", redirectToActionResult.ActionName);
    }

    [Fact]
    public async Task Delete_Post_ValidId_ReturnsJsonResult()
    {
        // Arrange
        var languageId = 1;
        var mockLanguageService = new Mock<ILanguageSevices>();
        mockLanguageService.Setup(service => service.Delete(languageId));

        var controller = new LanguageController(mockLanguageService.Object, null, null);

        // Act
        var result = await controller.Delete(languageId);

        // Assert
        var jsonResult = Assert.IsType<JsonResult>(result);
        Assert.True((bool)jsonResult.Value);
    }

    [Fact]
    public async Task Status_Post_ValidIdAndStatus_ReturnsJsonResult()
    {
        // Arrange
        var languageId = 1;
        var status = true;
        var mockLanguageService = new Mock<ILanguageSevices>();
        mockLanguageService.Setup(service => service.ChangeStatus(languageId, status));
        
        var controller = new LanguageController(mockLanguageService.Object, null, null);

        // Act
        var result = await controller.Status(languageId, status);

        // Assert
        var jsonResult = Assert.IsType<JsonResult>(result);
        Assert.True((bool)jsonResult.Value);
    }

}
