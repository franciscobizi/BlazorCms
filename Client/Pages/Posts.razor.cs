using System.Threading.Tasks;
using BlazorCms.ViewModels;
using Microsoft.AspNetCore.Components;

namespace BlazorCms.Client.Pages
{
    public partial class Posts
    {
        [Inject] IPostViewModel _postViewModel { get; set; }
        protected override async Task OnInitializedAsync() => await _postViewModel.GetAll();
        
    }
}