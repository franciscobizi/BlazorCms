using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorCms.Shared.Mapping;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Inputs;
using Syncfusion.Blazor.RichTextEditor;

namespace BlazorCms.ViewModels
{
    public interface IPostViewModel
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
        public string Display { get; set; }
        public int PostsPerPage { get; set; } 
        public List<PostResponse> Posts { get; set; }
        public PostResponse ThePost { get; set; }
        public List<ToolbarItemModel> Tools { get; set;}
        public Task Create();

        public Task GetAll();

        public Task GetOne(string param);

        public Task Update();
        public Task Search(string term);
        public void LoadMoreItems();
        public void OnImageRemovedSuccess(SuccessEventArgs args);
        public void OnImageUploadedSuccess(SuccessEventArgs args);
        public void OnSearchTermChange(KeyboardEventArgs args);
        public Task OnTheCommandClicked(CommandClickEventArgs<PostResponse> args);
        public void AddNewPost();
    }
}