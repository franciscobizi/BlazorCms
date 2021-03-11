using System;
using System.Threading.Tasks;
using BlazorCms.ViewModels;
using Microsoft.AspNetCore.Components;
using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorCms.Client.Pages
{
    public partial class NewPost
    {
        
        [Inject] IPostViewModel _postViewModel { get; set; }

        [CascadingParameter] private Task<AuthenticationState> _authenticationState { get; set; }
        protected override async Task OnInitializedAsync()
        {
            var authState = await _authenticationState;
            var user = authState.User;

            if(user.Identity.IsAuthenticated)
            {
                var claim = user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier);

                _postViewModel.PostAuthor = Convert.ToInt64(claim?.Value);

            }
        }
        
    }
}