using System;
using System.Threading.Tasks;
using BlazorCms.ViewModels;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
//using BlazorCms.Shared.Mapping;

namespace BlazorCms.Client.Pages
{
    public partial class Posts
    {
        
        [Inject] IPostViewModel _postViewModel { get; set; }
        //protected List<PostResponse> postResponse = new List<PostResponse>();

        protected override async Task OnInitializedAsync() => await _postViewModel.GetAll();
        
    }
}