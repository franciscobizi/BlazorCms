using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using BlazorCms.ViewModels;

namespace BlazorCms.Client.Pages
{
    public partial class Search
    {
        [Parameter] public string term { get; set; }
        [Inject] IPostViewModel _postViewModel { get; set; }
        protected async override Task OnInitializedAsync() => await _postViewModel.Search(term);
    }
}