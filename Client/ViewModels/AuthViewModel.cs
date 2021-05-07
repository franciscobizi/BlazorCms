using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using AutoMapper;
using BlazorCms.Shared.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace BlazorCms.ViewModels
{
    class AuthViewModel : IAuthViewModel
    {
        public long UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPass { get; set; }
        public string Message { get; set; } 

        public string Display { get; set; } = "none";
        public User TheUser { get; set; }

        private readonly HttpClient _Http;
        private readonly IMapper _mapper;
        private readonly NavigationManager _navigationManager;

        public AuthViewModel()
        {

        }
        // injecting httpClient 
        public AuthViewModel(HttpClient httpClient, NavigationManager navigationManager, IMapper mapper)
        {
            _Http = httpClient;
            _navigationManager = navigationManager;
            _mapper = mapper;
            this.TheUser = new User();
        }

        public async Task signIn()
        {
            var user = _mapper.Map<User>(this.TheUser);
            var response = await _Http.PostAsJsonAsync<User>(this._navigationManager.BaseUri +"user/signin", user);
            if(response.IsSuccessStatusCode)
            {
                _navigationManager.NavigateTo("bz-admin/profile", true);
            }
            else
            {
                this.Message = "Username or password is wrong. Try again";
                this.Display = "block";
            }

        }

        public async Task getCurrentUser()
        {
            var user = await _Http.GetFromJsonAsync<User>(this._navigationManager.BaseUri + "user/" + this.UserId);
            this.TheUser = user;
            
        }

        public void FacebookSignIn()
        {
            _navigationManager.NavigateTo(_navigationManager.BaseUri + "user/FacebookSignIn", true);
        }

        public void GoogleSignIn()
        {
            _navigationManager.NavigateTo(_navigationManager.BaseUri + "user/GoogleSignIn", true);
        }

    }
}