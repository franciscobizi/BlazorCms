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

namespace Tests.UnitTests
{
    public class UserTests : BaseTests
    {
        [Fact]
        public async Task GetAllUsers_ReturnsStatusCodeOk()
        {
            //Act
            var resp = await testClient.GetAsync(BaseUrl + "user/");
            //Assert
            resp.StatusCode.Should().Be(HttpStatusCode.OK);

        }

        [Fact]
        public async Task GetUser_WithId_ReturnsStatusCodeOk()
        {
            //Given
            var id = 1;
            //Act
            var resp = await testClient.GetAsync(BaseUrl + "user/" + id);
            //Assert
            resp.StatusCode.Should().Be(HttpStatusCode.OK);

        }
    }
}