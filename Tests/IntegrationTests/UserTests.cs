using System;
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

namespace Tests.IntegrationTests
{
    public class UserTests : BaseTests
    {
        [Fact]
        public async Task GetAllUsers_WithoutAnyUsers_ReturnsEmpty()
        {
            
            //Act
            var resp = await testClient.GetAsync(BaseUrl + "user/");
            //Assert
            resp.StatusCode.Should().Be(HttpStatusCode.OK);
            (await resp.Content.ReadAsAsync<List<User>>()).Should().BeEmpty(); // Should fail if there are users

        } 

        [Fact]
        public async Task GetAllPosts_WithPosts_ReturnsListOfUserss()
        {
            //Act
            var resp = await testClient.GetAsync(BaseUrl + "user/");
            //Assert
            resp.StatusCode.Should().Be(HttpStatusCode.OK);
            var posts = await resp.Content.ReadAsAsync<List<User>>();

        }

        [Fact]
        public async Task GetUser_WithId_ReturnsUser()
        {
            //Given
            var id = 1;
            //Act
            var resp = await testClient.GetAsync(BaseUrl + "user/" + id);
            //Assert
            resp.StatusCode.Should().Be(HttpStatusCode.OK);
            var user = await resp.Content.ReadAsAsync<User>();
            user.UserId.Should().Be(id);

        }
    }
}