
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
        Task<Post> CreatePostAsync(
                                    string PostTitle, 
                                    string PostPermalink, 
                                    string PostContent, 
                                    string PostThumbnail, 
                                    long PostAuthor, 
                                    string PostCreated, 
                                    string PostUpdated
                                );
        
        Task<Post> UpdatePostAsync(
                                    long PostId,
                                    string PostTitle, 
                                    string PostPermalink, 
                                    string PostContent, 
                                    string PostThumbnail, 
                                    long PostAuthor, 
                                    string PostCreated, 
                                    string PostUpdated
                                );

    }
}