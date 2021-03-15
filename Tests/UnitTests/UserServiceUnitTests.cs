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
    public class UserServiceUnitTests
    {
        private readonly UserServices _sut;
        private readonly Mock<blazorcmsContext> mockContext = new Mock<blazorcmsContext>();
        public PostsServiceUnitTests()
        {
            _sut = new UserServices(mockContext.Object);
            
        }
        
        [Fact]
        public async Task GetAllUsers_WithUsers_ShouldReturn_Users()
        {
            // Arrange
            mockContext.Setup(x => x.Users).Verifiable();
            // Act
            var users = await _sut.GetUsersAsync();
            // Assert
            Assert.Equal(1, users.Count);
        }
        
        [Fact]
        public async Task GetUserById_ShouldReturn_User()
        {
            // Arrange
            var id = 1;
            mockContext.Setup(x => x.Users).Verifiable();

            // Act
            var result = await _sut.GetCurrentUserAsync(id);

            // Assert
            Assert.Equal(1, result.UserId);

        }

        [Fact]
        public async Task CreateUser_ShouldReturn_CreatedUser()
        {
            // Arrange
            var user = new User(){
                UserEmail = "test@test.com",
                UserPass = "1111"
            };
            mockContext.Setup(x => x.Users).Verifiable();

            // Act
            var creaated_user = await _sut.CreateUserAsync(user);

            // Assert
            Assert.Equal(user.UserEmail, creaated_user.UserEmail);

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

            mockContext.Setup(x => x.Users).Verifiable();

            // Act
            var updated_user = await _sut.UpdateUserAsync(user);

            // Assert
            Assert.Equal(user.UserId, updated_user.UserId);
        }

    }
} 