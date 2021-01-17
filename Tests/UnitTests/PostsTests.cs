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
    public class PostsTests : BaseTests
    {
        [Fact]
        public async Task GetAllPosts_WithPosts_ReturnsStatusCodeOk()
        {
            //Act
            var resp = await testClient.GetAsync(BaseUrl + "posts/");
            //Assert
            resp.StatusCode.Should().Be(HttpStatusCode.OK);

        }

        [Fact]
        public async Task GetPost_WithId_ReturnsStatusCodeOk()
        {
            //Given
            var id = 1;
            //Act
            var resp = await testClient.GetAsync(BaseUrl + "posts/" + id);
            //Assert
            resp.StatusCode.Should().Be(HttpStatusCode.OK);

        }

        [Fact]
        public async Task CreatePost_WithData_ReturnsStatusCodeOk()
        {
            //Given
            Post post = new Post();
            post.PostTitle = "Testing post test";
            post.PostContent = "This is test post content";
            post.PostAuthor = 1;
            
            //Act
            var resp = await testClient.PostAsJsonAsync(BaseUrl + "posts/",post);
            //Assert
            resp.StatusCode.Should().Be(HttpStatusCode.OK);

        }

        [Fact]
        public async Task UpdatePost_WithData_ReturnsStatusCodeOk()
        {
            //Given
            Post post = new Post();
            post.PostId = 1;
            post.PostTitle = "Testing post test";
            post.PostContent = "This is test post content";
            
            //Act
            var resp = await testClient.PutAsJsonAsync(BaseUrl + "posts/",post);
            //Assert
            resp.StatusCode.Should().Be(HttpStatusCode.OK);

        }
    }
}