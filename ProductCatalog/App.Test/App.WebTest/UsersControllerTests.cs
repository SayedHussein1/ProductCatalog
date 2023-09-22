using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using App.Admin.Controllers;
using App.Application.Interfaces;
using App.Application.Model;
using System.Threading.Tasks;

public class UsersControllerTests
{
    [Fact]
    public async Task AddEdit_Get_ReturnsView()
    {
        // Arrange
        var userId = "1";
        var mockUsersService = new Mock<IUsersService>();
        mockUsersService.Setup(service => service.GetUserById(userId))
            .ReturnsAsync(new UserModel { Id = userId });

        var controller = new UsersController(mockUsersService.Object, null, null);

        // Act
        var result = await controller.AddEdit(userId);

        // Assert
        Assert.IsType<ViewResult>(result);
    }

    [Fact]
    public async Task AddEdit_Post_ValidModel_ReturnsRedirectToAction()
    {
        // Arrange
        var userModel = new UserModel { Id = "1" };
        var mockUsersService = new Mock<IUsersService>();
        mockUsersService.Setup(service => service.CreateUpdateAsync(userModel))
            .ReturnsAsync("Succeeded");

        var controller = new UsersController(mockUsersService.Object, null, null);

        // Act
        var result = await controller.AddEdit(userModel);

        // Assert
        var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
        Assert.Equal("Index", redirectToActionResult.ActionName);
    }

    [Fact]
    public async Task ChangePassword_Get_ReturnsView()
    {
        // Arrange
        var userId = "1";
        var controller = new UsersController(null, null, null);

        // Act
        var result =  controller.ChangePassword(userId);

        // Assert
        Assert.IsType<ViewResult>(result);
    }

    [Fact]
    public async Task ChangePassword_Post_ValidModel_ReturnsRedirectToAction()
    {
        // Arrange
        var changePasswordModel = new ChangePasswordModel { Id = "1" };
        var mockUsersService = new Mock<IUsersService>();
        mockUsersService.Setup(service => service.RestPasswordAsync(changePasswordModel.Id, changePasswordModel.Password))
            .ReturnsAsync("Succeeded");

        var controller = new UsersController(mockUsersService.Object, null, null);

        // Act
        var result = await controller.ChangePassword(changePasswordModel);

        // Assert
        var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
        Assert.Equal("Index", redirectToActionResult.ActionName);
    }

    [Fact]
    public async Task Status_Post_ValidIdAndStatus_ReturnsJsonResult()
    {
        // Arrange
        var userId = "1";
        var status = true;
        var mockUsersService = new Mock<IUsersService>();
        mockUsersService.Setup(service => service.ChangeStatus(userId, status))
            .Returns(Task.CompletedTask);

        var controller = new UsersController(mockUsersService.Object, null, null);

        // Act
        var result = await controller.Status(userId, status);

        // Assert
        var jsonResult = Assert.IsType<JsonResult>(result);
        Assert.True((bool)jsonResult.Value);
    }

}
