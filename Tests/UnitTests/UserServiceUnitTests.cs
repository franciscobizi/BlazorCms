using System;
using BlazorCms.Server.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Xunit;
using BlazorCms.Server.Services;

namespace Tests.UnitTests
{
    public class UserServiceUnitTests
    {
        public const string _user = "user";
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
                        UserEmail = $"{_user}{i}@example.com",
                        UserPass = $"{_user}{i}",
                        UserSource = "LOCALTEST",
                        UserRoles = "Editors",
                        UserFname = $"{_user}{i}first",
                        UserLname = $"{_user}{i}last",
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
                UserFname = $"{_user}2first",
                UserLname = $"{_user}2first"
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
                        UserEmail = $"{_user}7@example.com",
                        UserPass = $"{_user}7",
                        UserSource = "LOCALTEST",
                        UserRoles = "Editors",
                        UserFname = $"{_user}7first",
                        UserLname = $"{_user}7last",
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