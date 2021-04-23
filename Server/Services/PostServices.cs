using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCms.Server.Helpers;
using BlazorCms.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCms.Server.Services
{
    public class PostServices : IPostServices
    {
        private readonly blazorcmsContext _context;

        public PostServices(blazorcmsContext context)
        {
            _context = context;
        }

        public async Task<Post> CreatePostAsync(Post post)
        {
            post.PostPermalink = Utility.ToUrlFriendly(post.PostTitle);
            post.PostUpdated = post.PostCreated;
            await _context.AddAsync(post);
            await _context.SaveChangesAsync();
            return post;
        }
        
        public async Task<List<Post>> Search(string PostTitle)
        {
            var posts =_context.Posts.Where(p => EF.Functions.Like(p.PostTitle, $"%{PostTitle}%")).Include(u => u.PostAuthorNavigation).ToList();
            return await Task.FromResult(posts);
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

        public async Task<List<Post>> GetPostsAsync()
        {
            var posts = _context.Posts.Include(u => u.PostAuthorNavigation).ToList();
            return await Task.FromResult(posts);
        }

        public async Task<Post> UpdatePostAsync(Post post)
        {
            DateTime today = DateTime.Now;

            var postToUpdate = await _context.Posts.Where(u => u.PostId == post.PostId).FirstOrDefaultAsync();
            postToUpdate.PostTitle = post.PostTitle;
            postToUpdate.PostContent = post.PostContent;
            postToUpdate.PostThumbnail = post.PostThumbnail;
            postToUpdate.PostCreated = post.PostCreated;
            postToUpdate.PostUpdated = today.ToString("dd/MM/yyyy");

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