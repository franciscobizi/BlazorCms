using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Threading.Tasks;
using BlazorCms.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorCms.Client
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly HttpClient _Http;
        private string BaseAddress = "https://localhost:5001/user/";

        public CustomAuthenticationStateProvider(HttpClient httpClient)
        {
            _Http = httpClient;
        }

        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            User currentUser = await _Http.GetFromJsonAsync<User>(this.BaseAddress + "getcurrentuser");

            if(currentUser != null && currentUser.UserEmail != null)
            {
                 //create a claims
                var claimUserFname = new Claim(ClaimTypes.Name, (currentUser.UserFname ?? currentUser.UserEmail));
                var claimNameIdentifier = new Claim(ClaimTypes.NameIdentifier, Convert.ToString(currentUser.UserId));
                //create claimsIdentity
                var claimsIdentity = new ClaimsIdentity(new[] { claimUserFname, claimNameIdentifier }, "serverAuth");
                //create claimsPrincipal
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                return new AuthenticationState(claimsPrincipal);
            }
            else
                return new AuthenticationState(new ClaimsPrincipal( new ClaimsIdentity()));
        }
    }
}