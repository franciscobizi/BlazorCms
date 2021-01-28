using System;
using System.Threading;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using BlazorCms.Server.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorCms.Server;
using Microsoft.AspNetCore.Mvc.Testing;
using FluentAssertions;
using Xunit;
using Newtonsoft.Json;
using BlazorCms.Shared.Mapping;
using System.Net.Http.Json;
using Moq;
using MediatR;
using AutoMapper;
using BlazorCms.Server.Services;
using BlazorCms.Server.CQRS.Handlers;
using BlazorCms.Server.CQRS.Queries;
using BlazorCms.Server.CQRS.Commands;
using BlazorCms.Server.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Tests.UnitTests
{
    public class UserControllerUnitTests
    {
        private readonly UserController _sut;
        private readonly Mock<IUserServices> _services = new Mock<IUserServices>();
        private readonly Mock<IMediator> _mediator = new Mock<IMediator>();
        public UserControllerUnitTests()
        {
            _sut = new UserController(_mediator.Object);
        }
        
        [Fact]
        public async Task GetAllUsers_WithUsers_ShouldReturn_Users()
        {
            // Arrange
            _mediator.Setup(x => x.Send(It.IsAny<GetAllUsersQuery>(),new CancellationToken()));

            // Act
            var result = await _sut.GetAllUsers();
            
            // Assert
            Assert.IsType<OkObjectResult>(result);
        }
        
        [Fact]
        public async Task GetUserById_ShouldReturn_User()
        {
            // Arrange
            var id = 1;

            _mediator.Setup(x => x.Send(It.IsAny<GetUserByIdQuery>(),new CancellationToken()));

            // Act
            var result = await _sut.GetUser(id);

            // Assert
            Assert.IsType<OkObjectResult>(result);

        }

        [Fact]
        public async Task CreateUser_ShouldReturn_CreatedUser()
        {
            // Arrange
            var user = new User(){
                UserEmail = "test@test.com",
                UserPass = "1111"
            };

            _mediator.Setup(x => x.Send(It.IsAny<CreateUserCommand>(),new CancellationToken()));

            // Act
            var result = await _sut.CreateUser(user);

            // Assert
            Assert.IsType<OkObjectResult>(result);

        }

        [Fact]
        public async Task UpdateUser_ShouldReturn_UpdatedUser()
        {
            // Arrange
            var user = new User(){
                UserId = 1,
                UserEmail = "test@test.com",
                UserPass = "1111"
            };

            _mediator.Setup(x => x.Send(It.IsAny<UpdateUserCommand>(),new CancellationToken()));

            // Act
            var result = await _sut.UpdateUser(user);

            // Assert
            Assert.IsType<OkObjectResult>(result);

        }

    }
}