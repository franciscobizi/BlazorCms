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
        private async Task<blazorcmsContext> SetGetDatabaseContext()
        {
            var options = new DbContextOptionsBuilder<blazorcmsContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            var databaseContext = new blazorcmsContext(options);
            databaseContext.Database.EnsureCreated();
            if (await databaseContext.Users.CountAsync() <= 0)
            {
                for (int i = 1; i <= 6; i++)
                {
                    databaseContext.Users.Add(new User()
                    {
                        UserId = i,
                        UserEmail = $"user{i}@example.com",
                        UserPass = $"user{i}",
                        UserSource = "LOCALTEST",
                        UserRoles = "Editors",
                        UserFname = $"user{i}first",
                        UserLname = $"user{i}last",
                        UserAvatar = "NO",
                        UserStatus = "Active",
                        UserRegistered = DateTime.UtcNow.ToString(),
                        UserLogged = DateTime.UtcNow.ToString()
                    });
                    await databaseContext.SaveChangesAsync();
                }
            }
            return databaseContext;
        }
        
        [Fact]
        public async Task GetAllUsers_WithUsers_ShouldReturn_Users()
        {
            // Arrange
            var dbContext = await SetGetDatabaseContext();
            var _sut = new UserServices(dbContext);

            // Act
            var _users = await _sut.GetUsersAsync();

            // Assert
            Assert.Equal(6, _users.Count); // will fail if enter number greater or less that 6
        }
        
        [Fact]
        public async Task GetUserById_ShouldReturn_User()
        {
            // Arrange
            var id = 2;
            var user = new User(){
                UserId = id,
                UserFname = "User2first",
                UserLname = "User2first"
            };
            
            var dbContext = await SetGetDatabaseContext();
            var _sut = new UserServices(dbContext);

            // Act
            var result = await _sut.GetUserAsync(id);

            // Assert
            Assert.Equal(id, result.UserId);
            Assert.Equal(user.UserFname, result.UserFname);

        }

        [Fact]
        public async Task CreateUser_ShouldReturn_CreatedUser()
        {
            // Arrange
            var user = new User()
            {
                        UserId = 7,
                        UserEmail = "user7@example.com",
                        UserPass = "user7",
                        UserSource = "LOCALTEST",
                        UserRoles = "Editors",
                        UserFname = "User7first",
                        UserLname = "User7last",
                        UserAvatar = "NO",
                        UserStatus = "Active",
                        UserRegistered = DateTime.UtcNow.ToString(),
                        UserLogged = DateTime.UtcNow.ToString()
            };

            // Act
            var dbContext = await SetGetDatabaseContext();
            var _sut = new UserServices(dbContext);

            var creaated_user = await _sut.CreateUserAsync(user);

            // Assert
            Assert.Equal(user.UserEmail, creaated_user.UserEmail);
            Assert.Same(user,creaated_user);

        }

        [Fact]
        public async Task UpdateUser_ShouldReturn_UpdatedUser()
        {
            // Arrange
            var user = new User(){
                UserId = 1,
                UserFname = "Francisco",
                UserLname = "Bizi",
                UserRoles = "Admin"
            };
            
            // Act
            var dbContext = await SetGetDatabaseContext();
            var _sut = new UserServices(dbContext);
            var updated_user = await _sut.UpdateUserAsync(user);
            //Assert
            Assert.Equal(user.UserFname, updated_user.UserFname);
        }

    }
} 