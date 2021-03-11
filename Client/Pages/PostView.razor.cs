using System;
using System.Threading.Tasks;
using BlazorCms.ViewModels;
using Microsoft.AspNetCore.Components;

namespace BlazorCms.Client.Pages
{
    public partial class PostView
    {
        [Inject] IPostViewModel _postViewModel { get; set; }

        [Parameter] public string postPermalink { get; set; }
        protected override async Task OnInitializedAsync() => await _postViewModel.GetOne(this.postPermalink);
    }
}