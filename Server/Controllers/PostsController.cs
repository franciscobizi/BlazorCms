using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using BlazorCms.Server.CQRS.Queries;
using BlazorCms.Server.CQRS.Commands;
using BlazorCms.Shared.Mapping;
using BlazorCms.Server.CQSR.Queries;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Hosting;
using Server.CQSR.Queries;
using Azure.Storage.Blobs;
using System.Text;
using Azure.Storage.Blobs.Models;
using BlazorCms.Server.CQSR.Commands;

namespace BlazorCms.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IMediator _imediator;
        private readonly BlobServiceClient _BlobServiceClient;
        private readonly IWebHostEnvironment _IWebHostEnvironment;
        private string UploadFolder { get; set; } = @"/wwwroot/uploads/images/";

        public PostsController(IMediator imediator, IWebHostEnvironment IWebHostEnvironment, BlobServiceClient BlobServiceClient)
        {
            _imediator = imediator;
            _IWebHostEnvironment = IWebHostEnvironment;
            _BlobServiceClient = BlobServiceClient;
        }

        [HttpPost("")]
        public async Task<IActionResult> CreatePost([FromBody] CreatePostCommand command)
        {
            var result = await _imediator.Send(command);
            return CreatedAtAction("GetPost", new {PostId = result.PostId},result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPosts()
        {
            var query = new GetAllPostsQuery();
            var posts = await _imediator.Send(query);

            if(posts != null)
            {
                List<PostResponse> Items = new List<PostResponse>();

                foreach(var post in posts)
                {
                    var author = post.PostAuthorNavigation.UserFname + " " + post.PostAuthorNavigation.UserLname;
                    Items.Add(new PostResponse()
                    {
                        PostId = post.PostId,
                        PostTitle = post.PostTitle,
                        PostPermalink = post.PostPermalink,
                        PostContent = post.PostContent,
                        PostThumbnail = post.PostThumbnail,
                        PostAuthor =  post.PostAuthor,
                        PostAuthorName =  author,
                        PostCreated = post.PostCreated,
                        PostUpdated = post.PostUpdated
                    });
                }
                var Count = Items.Count();
                return Ok(new{Items, Count});
            }

            return Ok(posts);
        }

        [HttpGet("{param}")]
        public async Task<IActionResult> GetPost( string param)
        {
            var query = new GetPostByParamQuery(param);
            var post = await _imediator.Send(query);

            if(post != null)
            {
                PostResponse Items = new PostResponse();

                var author = post.PostAuthorNavigation.UserFname + " " + post.PostAuthorNavigation.UserLname;
                Items.PostId = post.PostId;
                Items.PostTitle = post.PostTitle;
                Items.PostPermalink = post.PostPermalink;
                Items.PostContent = post.PostContent;
                Items.PostThumbnail = post.PostThumbnail;
                Items.PostAuthor =  post.PostAuthor;
                Items.PostAuthorName =  author;
                Items.PostCreated = post.PostCreated;
                Items.PostUpdated = post.PostUpdated;
                return (IActionResult) Ok(Items);
            }
            
            return NotFound();
        }

        [HttpGet("search/{param}")]
        public async Task<IActionResult> Search( string param)
        {
            var query = new SearchPostQuery(param);
            var posts = await _imediator.Send(query);

            if(posts != null)
            {
                List<PostResponse> Items = new List<PostResponse>();

                foreach(var post in posts)
                {
                    var author = post.PostAuthorNavigation.UserFname + " " + post.PostAuthorNavigation.UserLname;
                    Items.Add(new PostResponse()
                    {
                        PostId = post.PostId,
                        PostTitle = post.PostTitle,
                        PostPermalink = post.PostPermalink,
                        PostContent = post.PostContent,
                        PostThumbnail = post.PostThumbnail,
                        PostAuthor =  post.PostAuthor,
                        PostAuthorName =  author,
                        PostCreated = post.PostCreated,
                        PostUpdated = post.PostUpdated
                    });
                }
                return (IActionResult) Ok(Items);
            }
            
            return NotFound();
        }

        [HttpPut("")]
        public async Task<IActionResult> UpdatePost([FromBody] UpdatePostCommand command)
        {
            var result = await _imediator.Send(command);
            return CreatedAtAction("GetPost", new {PostId = result.PostId},result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePost( int id)
        {
            var query = new DeletePostQuery(id);
            var result = await _imediator.Send(query);
            return result != null ? (IActionResult) Ok(result) : NotFound();
        }

        [HttpPost("uploadimage")]
        public async Task<IActionResult> UploadImage(IFormFile UploadFiles)
        {
            UploadOrDeleImageCommand command = new UploadOrDeleImageCommand()
            {
                file = UploadFiles,
                _action = "Upload"
            };

            var result = await _imediator.Send(command);
            Response.Headers.Add("fileName", result);
            return result != null ? (IActionResult) Ok(result) : NotFound();
            
        }

        [HttpPost("removeimage")]
        public async Task<IActionResult> DeleteImage(IFormFile UploadFiles)
        {
            UploadOrDeleImageCommand command = new UploadOrDeleImageCommand()
            {
                file = UploadFiles,
                _action = "Delete"
            };

            var result = await _imediator.Send(command);
            Response.Headers.Add("fileName", result);
            return result != null ? (IActionResult) Ok(result) : NotFound();
            
        }
        
    }
}
