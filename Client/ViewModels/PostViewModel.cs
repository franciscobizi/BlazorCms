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
using Microsoft.AspNetCore.Components;

namespace BlazorCms.ViewModels
{
    class PostViewModel : IPostViewModel
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostPermalink { get; set; }
        public string PostContent { get; set; }
        public string PostThumbnail { get; set; }
        public string PostCreated { get; set; }
        public string PostUpdated { get; set; }
        public int PostAuthor { get; set; }
        public string PostAuthorName { get; set; }
        public string Message { get; set; }
        public string Display  { get; set; } = "none";
        public List<PostResponse> Posts { get; set; }
        private readonly HttpClient _Http;
        private readonly NavigationManager _navigationManager;
        public PostViewModel()
        {

        }

        public PostViewModel(HttpClient httpClient, NavigationManager navigationManager)
        {
            _Http = httpClient;
            _navigationManager = navigationManager;
        }
        
        public async Task Create()
        {
            PostResponse post = this;
            await _Http.PostAsJsonAsync(this._navigationManager.BaseUri, post);
            this.Message = "Post created successful!";
            this.Display = "block";
        }

        public async Task GetAll()
        {
            /* var posts = await _Http.GetFromJsonAsync<List<PostResponse>>(this._navigationManager.BaseUri);
            LoadCurrentObject(posts); */
            var items = await _Http.GetStringAsync(this._navigationManager.BaseUri + "posts");
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
            PostResponse post = await _Http.GetFromJsonAsync<PostResponse>(this._navigationManager.BaseUri +
            "posts/" + param);
            LoadCurrentSingleObject(post);
        }

        public async Task Update()
        {

            PostResponse post = this;
            await _Http.PutAsJsonAsync(this._navigationManager.BaseUri + "posts", post);
            this.Message = "Post updated successful!";
            this.Display = "block";
        }

        public async Task Remove(int Id)
        {
            PostResponse post = this;
            post.PostId = Id;
            await _Http.DeleteAsync(this._navigationManager.BaseUri +"posts?id="+Id);
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
                PostAuthor = postViewModel.PostAuthor,
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