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
using Server.CQSR.Queries;
using BlazorCms.Server.CQSR.Commands;
using AutoMapper;
using BlazorCms.Server.Models;

namespace BlazorCms.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IMediator _imediator;
        private readonly IMapper _imapper;
        public PostsController(IMediator imediator, IMapper imapper)
        {
            _imediator = imediator;
            _imapper = imapper;
        }

        [HttpPost("")]
        public async Task<IActionResult> CreatePost([FromBody] Post post)
        {
            CreatePostCommand command = new CreatePostCommand(){post = post};
            var result = await _imediator.Send(command);
            var Items = _imapper.Map<PostResponse>(result);
            return (IActionResult) Ok(Items);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPosts()
        {
            var query = new GetAllPostsQuery();
            var posts = await _imediator.Send(query);

            if(posts != null)
            {
                List<PostResponse> Items = _imapper.Map<List<Post>, List<PostResponse>>(posts);
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
                var Items = _imapper.Map<PostResponse>(post);
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
                List<PostResponse> Items = _imapper.Map<List<PostResponse>>(posts);
                return (IActionResult) Ok(Items);
            }
            
            return NotFound();
        }

        [HttpPut("")]
        public async Task<IActionResult> UpdatePost([FromBody] Post post)
        {
            UpdatePostCommand command = new UpdatePostCommand(){post = post};
            var result = await _imediator.Send(command);
            var Items = _imapper.Map<PostResponse>(result);
            return (IActionResult) Ok(Items);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePost( int id)
        {
            var query = new DeletePostQuery(id);
            var result = await _imediator.Send(query);
            return result != null ? (IActionResult) Ok(result) : NotFound();
        }

        
        
    }
}
