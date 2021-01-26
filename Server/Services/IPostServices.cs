
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorCms.Server.Models;

namespace BlazorCms.Server.Services
{
    public interface IPostServices
    {
        List<Post> GetPostsAsync();
        Task<Post> GetPostByParamAsync(string param);
        Task<Post> DeletePostAsync(int id);
        List<Post> Search(string PostTitle);
        Task<Post> CreatePostAsync(Post post);
        
        Task<Post> UpdatePostAsync(Post post);

    }
}