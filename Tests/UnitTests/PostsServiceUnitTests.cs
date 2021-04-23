using System;
using BlazorCms.Server.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Xunit;
using BlazorCms.Server.Services;

namespace Tests.UnitTests
{
    public class PostsServiceUnitTests
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
                    databaseContext.Posts.Add(new Post()
                    {
                        PostId = i,
                        PostTitle = $"Title {i} test",
                        PostPermalink = $"title-{i}-test",
                        PostContent = "Post test content",
                        PostCategory = "Test category", 
                        PostThumbnail = "thumbnail.svg",
                        PostAuthor  = 1,
                        PostCreated = DateTime.UtcNow.ToString(),
                        PostUpdated = DateTime.UtcNow.ToString()
                    });
                    await databaseContext.SaveChangesAsync();
                }
            }
            return databaseContext;
        }
        
        [Fact]
        public async Task GetAllPosts_WithPosts_ShouldReturn_Posts()
        {
            // Arrange
            var dbContext = await SetGetDatabaseContext();
            var _sut = new PostServices(dbContext);

            // Act
            var posts = await _sut.GetPostsAsync();

            // Assert
            Assert.Equal(6, posts.Count); // will fail if enter number greater or less that 6
        }
        
        [Fact]
        public async Task GetPostByParam_ShouldReturn_Post()
        {
           // Arrange
            var param = "2";
            var dbContext = await SetGetDatabaseContext();
            var _sut = new PostServices(dbContext);
            // Act
            var post = await _sut.GetPostByParamAsync(param);
            // Assert
            Assert.Equal(2, post.PostId);

        }

        [Fact]
        public async Task CreatePost_ShouldReturn_CreatedPost()
        {
            // Arrange
            var post = new Post(){
                PostTitle = "Testing post test unit tests",
                PostContent = "This is test post content",
                PostAuthor = 1
            };
            // Act
            var dbContext = await SetGetDatabaseContext();
            var _sut = new PostServices(dbContext);
            var result = await _sut.CreatePostAsync(post);
            // Assert
            Assert.Equal(post.PostTitle, result.PostTitle);

        }

        [Fact]
        public async Task UpdatePost_ShouldReturn_UpdatedPost()
        {
            // Arrange
            var post = new Post(){
                PostId = 4,
                PostTitle = "Testing post test",
                PostContent = "This is test post content"
            };

            // Act
            var dbContext = await SetGetDatabaseContext();
            var _sut = new PostServices(dbContext);
            var result = await _sut.UpdatePostAsync(post);

            // Assert
            Assert.Equal(post.PostTitle, result.PostTitle);

        }

        [Fact]
        public async Task DeletePost_ShouldReturn_DeletedPost()
        {
            // Arrange
            var id = 4;

            // Act
            var dbContext = await SetGetDatabaseContext();
            var _sut = new PostServices(dbContext);
            var post = await _sut.DeletePostAsync(id);

            // Assert
            Assert.Equal(4, post.PostId);

        }
    }
}