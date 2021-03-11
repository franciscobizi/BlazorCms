using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using BlazorCms.ViewModels;
using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorCms.Client.Pages
{
    public partial class UserProfile
    {
        [Inject] IProfileViewModel _profileVM { get; set; }
        [CascadingParameter] private Task<AuthenticationState> _authenticationState { get; set; }
        // loading user profile data
        protected override async Task OnInitializedAsync()
        {
            var authState = await _authenticationState;
            var user = authState.User;

            if(user.Identity.IsAuthenticated)
            {
                var claim = user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier);

                _profileVM.UserId = Convert.ToInt64(claim?.Value);

                await _profileVM.getProfile();

            }
        }
    }
}