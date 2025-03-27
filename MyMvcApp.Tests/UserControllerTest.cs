/*using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Controllers;
using MyMvcApp.Models;
using Xunit;
using System.Linq;

namespace MyMvcApp.Tests.Controllers
{
    public class UserControllerTest
    {
        [Fact]
        public void Index_ReturnsViewResult_WithUserList()
        {
            // Arrange
            var controller = new UserController();

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<System.Collections.Generic.List<User>>(viewResult.Model);
            Assert.Equal(UserController.userlist, model);
        }

        [Fact]
        public void Details_ReturnsViewResult_WithUser()
        {
            // Arrange
            var controller = new UserController();
            var user = new User { Id = 1, Name = "Test User", Email = "test@example.com" };
            UserController.userlist.Add(user);

            // Act
            var result = controller.Details(1);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<User>(viewResult.Model);
            Assert.Equal(user, model);
        }

        [Fact]
        public void Details_ReturnsNotFound_WhenUserNotFound()
        {
            // Arrange
            var controller = new UserController();

            // Act
            var result = controller.Details(999);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void Create_PostValidUser_RedirectsToIndex()
        {
            // Arrange
            var controller = new UserController();
            var user = new User { Id = 2, Name = "New User", Email = "new@example.com" };

            // Act
            var result = controller.Create(user);

            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectToActionResult.ActionName);
            Assert.Contains(user, UserController.userlist);
        }

        [Fact]
        public void Create_PostInvalidUser_ReturnsViewResult()
        {
            // Arrange
            var controller = new UserController();
            controller.ModelState.AddModelError("Name", "Required");
            var user = new User { Id = 3, Email = "invalid@example.com" };

            // Act
            var result = controller.Create(user);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(user, viewResult.Model);
        }

        [Fact]
        public void Edit_GetValidUser_ReturnsViewResult()
        {
            // Arrange
            var controller = new UserController();
            var user = new User { Id = 4, Name = "Edit User", Email = "edit@example.com" };
            UserController.userlist.Add(user);

            // Act
            var result = controller.Edit(4);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<User>(viewResult.Model);
            Assert.Equal(user, model);
        }

        [Fact]
        public void Edit_GetInvalidUser_ReturnsNotFound()
        {
            // Arrange
            var controller = new UserController();

            // Act
            var result = controller.Edit(999);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void Edit_PostValidUser_RedirectsToIndex()
        {
            // Arrange
            var controller = new UserController();
            var user = new User { Id = 5, Name = "Old Name", Email = "old@example.com" };
            UserController.userlist.Add(user);
            var updatedUser = new User { Id = 5, Name = "Updated Name", Email = "updated@example.com" };

            // Act
            var result = controller.Edit(5, updatedUser);

            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectToActionResult.ActionName);
            Assert.Equal("Updated Name", user.Name);
            Assert.Equal("updated@example.com", user.Email);
        }

        [Fact]
        public void Edit_PostInvalidUser_ReturnsViewResult()
        {
            // Arrange
            var controller = new UserController();
            var user = new User { Id = 6, Name = "Invalid User", Email = "invalid@example.com" };
            UserController.userlist.Add(user);
            controller.ModelState.AddModelError("Name", "Required");

            // Act
            var result = controller.Edit(6, user);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(user, viewResult.Model);
        }

        [Fact]
        public void Delete_GetValidUser_ReturnsViewResult()
        {
            // Arrange
            var controller = new UserController();
            var user = new User { Id = 7, Name = "Delete User", Email = "delete@example.com" };
            UserController.userlist.Add(user);

            // Act
            var result = controller.Delete(7);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsType<User>(viewResult.Model);
            Assert.Equal(user, model);
        }

        [Fact]
        public void Delete_GetInvalidUser_ReturnsNotFound()
        {
            // Arrange
            var controller = new UserController();

            // Act
            var result = controller.Delete(999);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void Delete_PostValidUser_RedirectsToIndex()
        {
            // Arrange
            var controller = new UserController();
            var user = new User { Id = 8, Name = "Delete User", Email = "delete@example.com" };
            UserController.userlist.Add(user);

            // Act
            var result = controller.Delete(8, null);

            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectToActionResult.ActionName);
            Assert.DoesNotContain(user, UserController.userlist);
        }

        [Fact]
        public void Delete_PostInvalidUser_ReturnsNotFound()
        {
            // Arrange
            var controller = new UserController();

            // Act
            var result = controller.Delete(999, null);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}*/