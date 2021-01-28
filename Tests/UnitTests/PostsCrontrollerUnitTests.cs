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
    public class PostsControllerUnitTests
    {
        private readonly PostsController _sut;
        private readonly Mock<IPostServices> _services = new Mock<IPostServices>();
        private readonly Mock<IMediator> _mediator = new Mock<IMediator>();
        private readonly Mock<IMapper> _imapper = new Mock<IMapper>();
        public PostsControllerUnitTests()
        {
            _sut = new PostsController(_mediator.Object, _imapper.Object);
        }
        
        [Fact]
        public async Task GetAllPosts_WithPosts_ShouldReturn_Posts()
        {
            // Arrange
            _mediator.Setup(x => x.Send(It.IsAny<GetAllPostsQuery>(),new CancellationToken()));

            // Act
            var result = await _sut.GetAllPosts();
            
            // Assert
            Assert.IsType<OkObjectResult>(result);
        }
        
        [Fact]
        public async Task GetPostByParam_ShouldReturn_Post()
        {
            // Arrange
            var param = "1";

            _mediator.Setup(x => x.Send(It.IsAny<GetPostByParamQuery>(),new CancellationToken()));

            // Act
            var result = await _sut.GetPost(param);

            // Assert
            Assert.IsType<OkObjectResult>(result);

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

            _mediator.Setup(x => x.Send(It.IsAny<CreatePostCommand>(),new CancellationToken()));

            // Act
            var result = await _sut.CreatePost(post);

            // Assert
            Assert.IsType<OkObjectResult>(result);

        }

        [Fact]
        public async Task UpdatePost_ShouldReturn_UpdatedPost()
        {
            // Arrange
            var post = new Post(){
                PostTitle = "Testing post test",
                PostContent = "This is test post content"
            };

            _mediator.Setup(x => x.Send(It.IsAny<UpdatePostCommand>(),new CancellationToken()));

            // Act
            var result = await _sut.UpdatePost(post);

            // Assert
            Assert.IsType<OkObjectResult>(result);

        }

        [Fact]
        public async Task DeletePost_ShouldReturn_DeletedPost()
        {
            // Arrange
            var id = 1;

            _mediator.Setup(x => x.Send(It.IsAny<DeletePostQuery>(),new CancellationToken()));

            // Act
            var result = await _sut.DeletePost(id);

            // Assert
            Assert.IsType<OkObjectResult>(result);

        }
    }
}