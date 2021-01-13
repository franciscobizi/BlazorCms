using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection;
using System.Threading.Tasks;
using BlazorCms.Shared.Models;
using Syncfusion.Blazor.Inputs;
using System.Text.RegularExpressions;
using BlazorCms.Shared.Mapping;

namespace BlazorCms.ViewModels
{
    class PostViewModel : IPostViewModel
    {
        public long PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostPermalink { get; set; }
        public string PostContent { get; set; }
        public string PostThumbnail { get; set; }
        public string PostCreated { get; set; }
        public string PostUpdated { get; set; }
        public long PostAuthor { get; set; }
        public string PostAuthorName { get; set; }
        public string Message { get; set; }
        public string Display  { get; set; } = "none";
        public List<PostResponse> Posts { get; set; }
        private HttpClient _Http;
        private string BaseAddress = "https://localhost:5001/posts/";
        public PostViewModel()
        {

        }

        public PostViewModel(HttpClient httpClient)
        {
            _Http = httpClient;
        }
        
        public async Task Create()
        {
            PostResponse post = this;
            await _Http.PostAsJsonAsync(this.BaseAddress, post);
            this.Message = "Post created successful!";
            this.Display = "block";
        }

        public async Task GetAll()
        {
            /* var posts = await _Http.GetFromJsonAsync<List<PostResponse>>(this.BaseAddress);
            LoadCurrentObject(posts); */
            var items = await _Http.GetStringAsync(this.BaseAddress);
        }

        public void Delete(int id)
        {
            this.PostId = id;
        }
        private void LoadCurrentObject(List<PostResponse> Posts)
        {
            this.Posts = new List<PostResponse>();
            foreach (PostResponse post in Posts)
            {
                this.Posts.Add(post);
            }
        }

        private void LoadCurrentSingleObject(PostViewModel postViewModel)
        {
            this.PostId = postViewModel.PostId;
            this.PostTitle = postViewModel.PostTitle;
            this.PostPermalink = postViewModel.PostPermalink;
            this.PostContent = postViewModel.PostContent;
            this.PostAuthor = postViewModel.PostAuthor;
            this.PostAuthorName = postViewModel.PostAuthorName;
            this.PostCreated = postViewModel.PostCreated;
            this.PostThumbnail = postViewModel.PostThumbnail;
            //add more fields
        }

        public async Task GetOne(string param)
        {
            PostResponse post = await _Http.GetFromJsonAsync<PostResponse>(this.BaseAddress + param);
            LoadCurrentSingleObject(post);
        }

        public async Task Update()
        {

            PostResponse post = this;
            await _Http.PutAsJsonAsync(this.BaseAddress, post);
            this.Message = "Post updated successful!";
            this.Display = "block";
        }

        public async Task Remove(long Id)
        {
            PostResponse post = this;
            post.PostId = Id;
            await _Http.DeleteAsync(this.BaseAddress +"?id="+Id);
            this.Message = "Post removed successful!";
            this.Display = "block";
        }

        // convert model to viewmodel
        public static implicit operator PostViewModel(PostResponse postViewModel)
        {
            return new PostViewModel()
            {
                PostId = postViewModel.PostId,
                PostTitle = postViewModel.PostTitle,
                PostContent = postViewModel.PostContent,
                PostThumbnail = postViewModel.PostThumbnail,
                PostAuthor = postViewModel.PostAuthor,
                PostCreated = postViewModel.PostCreated
            };
        }

        // convert viewmodel to model
        public static implicit operator PostResponse(PostViewModel postViewModel)
        {
            return new PostResponse()
            {
                PostId = postViewModel.PostId,
                PostTitle = postViewModel.PostTitle,
                PostContent = postViewModel.PostContent,
                PostThumbnail = postViewModel.PostThumbnail,
                PostAuthor = Convert.ToInt64(postViewModel.PostAuthor),
                PostCreated = postViewModel.PostCreated
            };
        }
        
        public void OnImageUploadedSuccess(SuccessEventArgs args) 
        { 
            var customHeader = args.Response.Headers.Split(new Char[] { '\n' })[2]; 
            var ImageId = customHeader.Split(new Char[] { ':' })[1].Trim();
            this.PostThumbnail = ImageId;
        } 

        public void OnImageRemovedSuccess(SuccessEventArgs args)
        {
            PostResponse post = this;
            this.PostThumbnail = post.PostThumbnail;
        }

    }
}