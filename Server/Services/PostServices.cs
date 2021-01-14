using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCms.Server.Helpers;
using BlazorCms.Server.Models;
using BlazorCms.Shared.Mapping;
using Microsoft.EntityFrameworkCore;

namespace BlazorCms.Server.Services
{
    public class PostServices : IPostServices
    {
        private readonly BlazorCmsContext _context;

        public PostServices(BlazorCmsContext context)
        {
            _context = context;
        }

        public async Task<Post> CreatePostAsync(string PostTitle, string PostPermalink, string PostContent, string PostThumbnail, int PostAuthor, string PostCreated, string PostUpdated)
        {
            DateTime today = DateTime.Now;

            Post post = new Post();
            post.PostTitle = PostTitle;
            post.PostPermalink = Utility.ToUrlFriendly(PostTitle);
            post.PostContent = PostContent;
            post.PostThumbnail = PostThumbnail;
            post.PostAuthor = PostAuthor;
            post.PostCreated = today.ToString("yyyy-MM-dd");
            post.PostUpdated = today.ToString("yyyy-MM-dd");

            await _context.AddAsync(post);
            await _context.SaveChangesAsync();
            return await Task.FromResult(post);
        }

        public async Task<Post> GetPostByParamAsync(string param)
        {
            long PostId = 0;
            bool isNumeric = long.TryParse(param, out PostId);
            if(isNumeric)
            {
                return await _context.Posts.Where(p => p.PostId == Convert.ToInt64(param)).Include(u => u.PostAuthorNavigation).FirstOrDefaultAsync();
            }
            return await _context.Posts.Where(p => p.PostPermalink == param).Include(u => u.PostAuthorNavigation).FirstOrDefaultAsync();
        }

        public List<Post> GetPostsAsync()
        {
            var posts = _context.Posts.Include(u => u.PostAuthorNavigation);
            return posts.ToList();
        }

        public async Task<Post> UpdatePostAsync(int PostId, string PostTitle, string PostPermalink, string PostContent, string PostThumbnail, int PostAuthor, string PostCreated, string PostUpdated)
        {
            DateTime today = DateTime.Now;

            Post postToUpdate = await _context.Posts.Where(u => u.PostId == PostId).FirstOrDefaultAsync();
            postToUpdate.PostTitle = PostTitle;
            postToUpdate.PostContent = PostContent;
            postToUpdate.PostThumbnail = PostThumbnail;
            postToUpdate.PostUpdated = today.ToString("yyyy-MM-dd");

            await _context.SaveChangesAsync();

            return postToUpdate;
        }

        public async Task<Post> DeletePostAsync(int PostId)
        {
            var post =  _context.Posts.Single(p => p.PostId == PostId);
            _context.Remove(post);
            _context.SaveChanges();

            return await Task.FromResult(post);
        }
    }
}