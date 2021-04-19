using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Syncfusion.Blazor.Inputs;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor.RichTextEditor;
using BlazorCms.Shared.Mapping;
using Syncfusion.Blazor.Grids;

namespace BlazorCms.ViewModels
{
    class PostViewModel : IPostViewModel
    {
        public long PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostPermalink { get; set; }
        public string PostContent { get; set; }
        public string PostThumbnail { get; set; }
        public DateTime PostCreated { get; set; }
        public string PostUpdated { get; set; }
        public long PostAuthor { get; set; }
        public string PostAuthorName { get; set; }
        public string Message { get; set; }
        public string SearchTerm { get; set; }
        public string Display  { get; set; } = "none";
        public int PostsPerPage { get; set; } = 3;
        public List<PostResponse> Posts { get; set; }
        public List<ToolbarItemModel> Tools { get; set; }
        private readonly HttpClient _Http;
        private readonly NavigationManager _navigationManager;
        public PostViewModel()
        {

        }

        public PostViewModel(HttpClient httpClient, NavigationManager navigationManager)
        {
            _Http = httpClient;
            _navigationManager = navigationManager;

            Tools = new List<ToolbarItemModel>()
                    {
                        new ToolbarItemModel() { Command = ToolbarCommand.Bold },
                        new ToolbarItemModel() { Command = ToolbarCommand.Italic },
                        new ToolbarItemModel() { Command = ToolbarCommand.Underline },
                        new ToolbarItemModel() { Command = ToolbarCommand.StrikeThrough },
                        new ToolbarItemModel() { Command = ToolbarCommand.FontName },
                        new ToolbarItemModel() { Command = ToolbarCommand.FontSize },
                        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
                        new ToolbarItemModel() { Command = ToolbarCommand.FontColor },
                        new ToolbarItemModel() { Command = ToolbarCommand.BackgroundColor },
                        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
                        new ToolbarItemModel() { Command = ToolbarCommand.Formats },
                        new ToolbarItemModel() { Command = ToolbarCommand.Alignments },
                        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
                        new ToolbarItemModel() { Command = ToolbarCommand.LowerCase },
                        new ToolbarItemModel() { Command = ToolbarCommand.UpperCase },
                        new ToolbarItemModel() { Command = ToolbarCommand.SuperScript },
                        new ToolbarItemModel() { Command = ToolbarCommand.SubScript },
                        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
                        new ToolbarItemModel() { Command = ToolbarCommand.OrderedList },
                        new ToolbarItemModel() { Command = ToolbarCommand.UnorderedList },
                        new ToolbarItemModel() { Command = ToolbarCommand.Outdent },
                        new ToolbarItemModel() { Command = ToolbarCommand.Indent },
                        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
                        new ToolbarItemModel() { Command = ToolbarCommand.CreateLink },
                        new ToolbarItemModel() { Command = ToolbarCommand.Image },
                        new ToolbarItemModel() { Command = ToolbarCommand.CreateTable },
                        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
                        new ToolbarItemModel() { Command = ToolbarCommand.ClearFormat },
                        new ToolbarItemModel() { Command = ToolbarCommand.Print },
                        new ToolbarItemModel() { Command = ToolbarCommand.SourceCode },
                        new ToolbarItemModel() { Command = ToolbarCommand.FullScreen },
                        new ToolbarItemModel() { Command = ToolbarCommand.Separator },
                        new ToolbarItemModel() { Command = ToolbarCommand.Undo },
                        new ToolbarItemModel() { Command = ToolbarCommand.Redo }
                    };
        }
        
        
        public void LoadMoreItems() => this.PostsPerPage += 3;
        public async Task Create()
        {
            PostResponse post = this;
            await _Http.PostAsJsonAsync(this._navigationManager.BaseUri + "posts", post);
            this.Message = "Post created successful!";
            this.Display = "block";
        }

        public async Task GetAll()
        {
            var items = await _Http.GetFromJsonAsync<List<PostResponse>>(_navigationManager.BaseUri + "posts");
            LoadCurrentObject(items);
        }

        public void Delete(int id)
        {
            this.PostId = id;
        }
        private void LoadCurrentObject(List<PostResponse> Posts)
        {
            if (Posts != null)
            {
                this.Posts = new List<PostResponse>();
                foreach (PostResponse post in Posts)
                {
                    this.Posts.Add(post);
                }
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

        public async Task Remove(long Id)
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
                PostCreated = DateTime.Parse(postViewModel.PostCreated)
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
                PostCreated = postViewModel.PostCreated.ToString()
            };
        }
        
        public void OnImageUploadedSuccess(SuccessEventArgs args) 
        { 
            var customHeader = args.Response.Headers.ToString();
            string pattern = "https://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?";
            Regex regx = new Regex(pattern, RegexOptions.IgnoreCase);        
            var url = regx.Matches(customHeader); 
            this.PostThumbnail = url[0].Value;
        }

        public void OnImageRemovedSuccess(SuccessEventArgs args)
        {
            PostResponse post = this;
            this.PostThumbnail = post.PostThumbnail;
        }


        public void OnSearchTermChange(KeyboardEventArgs args)
        {
            if (args.Key == "Enter")
            {  
                _navigationManager.NavigateTo($"/search/{this.SearchTerm}",true);
            }
        }

        public async Task Search(string term)
        {
            if (term != null)
            {
                List<PostResponse> post = await _Http.GetFromJsonAsync<List<PostResponse>>(_navigationManager.BaseUri + "posts/search/" + term);
                LoadCurrentObject(post);
            }
        }

        public void AddNewPost()
        {
            _navigationManager.NavigateTo("/bz-admin/post/new/");
        }

        public async Task OnTheCommandClicked(CommandClickEventArgs<PostResponse> args)
        {
            var clicked = args.CommandColumn.Title;
            switch (clicked)
            {
                case "View":
                _navigationManager.NavigateTo("/blog/" + args.RowData.PostPermalink);
                break;
                case "Edit":
                _navigationManager.NavigateTo("/bz-admin/post/edit/" + args.RowData.PostId);
                break;
                case "Delete":
                await Remove(args.RowData.PostId);
                break;
                default:
                break;
            }
        }
    }
}