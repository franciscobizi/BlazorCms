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
using BlazorCms.Server.CQSR.Queries;
using BlazorCms.Server.CQRS.Commands;
using BlazorCms.Server.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Tests.UnitTests
{
    public class PostsServiceUnitTests
    {
        private readonly PostServices _sut;
        private readonly Mock<blazorcmsContext> mockContext = new Mock<blazorcmsContext>();
        public PostsServiceUnitTests()
        {
            _sut = new PostServices(mockContext.Object);
            
        }
        
        [Fact]
        public async Task GetAllPosts_WithPosts_ShouldReturn_Posts()
        {
            // Arrange
            mockContext.Setup(x => x.Posts).Verifiable();
            // Act
            var posts = await _sut.GetPostsAsync();
            // Assert
            Assert.Equal(5, posts.Count);
        }
        
        [Fact]
        public async Task GetPostByParam_ShouldReturn_Post()
        {
           // Arrange
            var param = "1";
            mockContext.Setup(x => x.Posts).Verifiable();
            // Act
            var post = await _sut.GetPostByParamAsync(param);
            // Assert
            Assert.Equal(1, post.Count);

        }

        [Fact]
        public async Task CreatePost_ShouldReturn_CreatedPost()
        {
            // Arrange
            var post = new Post(){
                PostTitle = "Testing post test",
                PostContent = "This is test post content",
                PostAuthor = 1
            };
            mockContext.Setup(x => x.Posts).Verifiable();
            // Act
            var result = await _sut.CreatePostAsync(post);
            // Assert
            Assert.Equal(post.PostTitle, result.PostTitle);

        }

        [Fact]
        public async Task UpdatePost_ShouldReturn_UpdatedPost()
        {
            // Arrange
            var post = new Post(){
                PostTitle = "Testing post test",
                PostContent = "This is test post content"
            };

            mockContext.Setup(x => x.Posts).Verifiable();
            // Act
            var result = await _sut.UpdatePostAsync(post);
            // Assert
            Assert.Equal(post.PostTitle, result.PostTitle);

        }

        [Fact]
        public async Task DeletePost_ShouldReturn_DeletedPost()
        {
            // Arrange
            var id = 1;

            mockContext.Setup(x => x.Posts).Verifiable();

            // Act
            var post = await _sut.DeletePostAsync(id);

            // Assert
            Assert.Equal(1, post.Count);

        }
    }
}