using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorCms.Server.Models;

namespace BlazorCms.Server.Services
{
    public interface IPostServices
    {
        Task<List<Post>> GetPostsAsync();
        Task<Post> GetPostByParamAsync(string param);
        Task<Post> DeletePostAsync(int id);
        Task<List<Post>> Search(string PostTitle);
        Task<Post> CreatePostAsync(Post post);
        Task<Post> UpdatePostAsync(Post post);

    }
}