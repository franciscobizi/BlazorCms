using System.Net;
using System.Collections.Generic;
using BlazorCms.Server.Models;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using System.Net.Http.Json;

namespace Tests.IntegrationTests
{
    public class PostsTests : BaseTests
    {
        [Fact]
        public async Task GetAllPosts_WithPosts_ReturnsListOfPosts()
        {
            //Act
            var resp = await testClient.GetAsync(BaseUrl + "posts/");
            //Assert
            resp.StatusCode.Should().Be(HttpStatusCode.OK);
            var posts = await resp.Content.ReadAsAsync<List<Post>>();

        }

        [Fact]
        public async Task GetPost_WithId_ReturnsPost()
        {
            //Given
            var id = 2;
            //Act
            var resp = await testClient.GetAsync(BaseUrl + "posts/" + id);
            //Assert
            resp.StatusCode.Should().Be(HttpStatusCode.OK);
            var post = await resp.Content.ReadAsAsync<Post>();
            post.PostId.Should().Be(id);

        }

        [Fact]
        public async Task CreatePost_WithData_ReturnsCreatedPost()
        {
            //Given
            Post post = new Post(){
                PostTitle = "Testing post test",
                PostContent = "This is test post content",
                PostAuthor = 1,
            };
            
            //Act
            var resp = await testClient.PostAsJsonAsync(BaseUrl + "posts/",post);
            //Assert
            resp.StatusCode.Should().Be(HttpStatusCode.OK);
            var createdPost = await resp.Content.ReadAsAsync<Post>();
            createdPost.PostTitle.Should().Be(post.PostTitle);

        }

        [Fact]
        public async Task UpdatePost_WithData_ReturnsUpdatedPost()
        {
            //Given
            Post post = new Post(){
                PostId = 2,
                PostTitle = "Testing post test update",
                PostContent = "This is test post content",
            };
            
            //Act
            var resp = await testClient.PutAsJsonAsync(BaseUrl + "posts/",post);
            //Assert
            resp.StatusCode.Should().Be(HttpStatusCode.OK);
            var UpdatedPost = await resp.Content.ReadAsAsync<Post>();
            UpdatedPost.PostTitle.Should().Be(post.PostTitle);

        }
    }
}