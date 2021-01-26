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

        public async Task<Post> CreatePostAsync(Post post)
        {
            Post _post = new Post();
            _post.PostTitle = post.PostTitle;
            _post.PostPermalink = Utility.ToUrlFriendly(post.PostTitle);
            _post.PostContent = post.PostContent;
            _post.PostThumbnail = post.PostThumbnail;
            _post.PostAuthor = post.PostAuthor;
            _post.PostCreated = post.PostCreated;
            _post.PostUpdated = post.PostCreated;

            await _context.AddAsync(_post);
            await _context.SaveChangesAsync();
            return await Task.FromResult(_post);
        }
        
        public List<Post> Search(string PostTitle)
        {
            return _context.Posts.Where(p => EF.Functions.Like(p.PostTitle, $"%{PostTitle}%")).Include(u => u.PostAuthorNavigation).ToList();
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

        public async Task<Post> UpdatePostAsync(Post post)
        {
            DateTime today = DateTime.Now;

            Post postToUpdate = await _context.Posts.Where(u => u.PostId == post.PostId).FirstOrDefaultAsync();
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