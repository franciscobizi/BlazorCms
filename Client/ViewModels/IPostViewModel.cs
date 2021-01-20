using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorCms.Shared.Mapping;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor.Inputs;

namespace BlazorCms.ViewModels
{
    public interface IPostViewModel
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
        public string SearchTerm { get; set; } 
        public string Display { get; set; } 
        public List<PostResponse> Posts { get; set; }

        public Task Create();

        public Task GetAll();

        public Task GetOne(string param);

        public Task Update();
        public Task Search(string term);
        public Task Remove(int Id);
        public void OnImageRemovedSuccess(SuccessEventArgs args);
        public void OnImageUploadedSuccess(SuccessEventArgs args);
        public void OnSearchTermChange(KeyboardEventArgs args);
        
    }
}