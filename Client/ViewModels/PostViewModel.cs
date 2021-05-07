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
using AutoMapper;

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
        public PostResponse ThePost {get; set;}
        public List<ToolbarItemModel> Tools { get; set; }
        private readonly HttpClient _Http;
        private readonly NavigationManager _navigationManager;
        private readonly IMapper _mapper;
        public PostViewModel()
        {

        }

        public PostViewModel(HttpClient httpClient, NavigationManager navigationManager, IMapper autoMapper)
        {
            _Http = httpClient;
            _navigationManager = navigationManager;
            _mapper = autoMapper;
            this.ThePost = new PostResponse();
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
            var post = _mapper.Map<PostResponse>(this.ThePost);
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

        public async Task GetOne(string param)
        {
            var post = await _Http.GetFromJsonAsync<PostResponse>(this._navigationManager.BaseUri +
            "posts/" + param);
            this.ThePost = post;
            this.PostCreated = !string.IsNullOrEmpty(this.ThePost.PostCreated) ? DateTime.Parse(this.ThePost.PostCreated) : this.PostCreated;
        }

        public async Task Update()
        {

            var post = _mapper.Map<PostResponse>(this.ThePost);
            post.PostCreated = this.PostCreated.ToString();
            await _Http.PutAsJsonAsync(this._navigationManager.BaseUri + "posts", post);
            this.Message = "Post updated successful!";
            this.Display = "block";
        }

        public async Task Remove(long Id)
        {
            var post = _mapper.Map<PostResponse>(this.ThePost);
            post.PostId = Id;
            await _Http.DeleteAsync(this._navigationManager.BaseUri +"posts?id="+Id);
            this.Message = "Post removed successful!";
            this.Display = "block";
        }

        public void OnImageUploadedSuccess(SuccessEventArgs args) 
        { 
            var customHeader = args.Response.Headers.ToString();
            string pattern = "https://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?";
            Regex regx = new Regex(pattern, RegexOptions.IgnoreCase);        
            var url = regx.Matches(customHeader); 
            this.ThePost.PostThumbnail = url[0].Value;
        }

        public void OnImageRemovedSuccess(SuccessEventArgs args)
        {
            var post = _mapper.Map<PostResponse>(this.ThePost);
            this.ThePost.PostThumbnail = post.PostThumbnail;
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