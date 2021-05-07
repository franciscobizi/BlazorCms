using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using AutoMapper;
using BlazorCms.Shared.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace BlazorCms.ViewModels
{
    class UserViewModel : IUserViewModel
    {
        public long UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPass { get; set; }
        public string UserSource { get; set; }
        public string UserFname { get; set; }
        public string UserLname { get; set; }
        public string UserAvatar { get; set; }
        public string UserStatus { get; set; }
        public string UserRegistered { get; set; }
        public string UserLogged { get; set; }
        public string Message { get; set; } 

        public string Display { get; set; } = "none";
        public List<User> users { get ; set; }
        public User TheUser { get ; set; }

        private readonly HttpClient _Http;
        private readonly NavigationManager _navigationManager;
        private readonly IMapper _mapper;

        public UserViewModel()
        {

        }
        // injecting httpClient 
        public UserViewModel(HttpClient httpClient, NavigationManager navigationManager, IMapper mapper)
        {
            _Http = httpClient;
            _navigationManager = navigationManager;
            _mapper = mapper;
            this.TheUser = new User();
        }

        public async Task UpdateProfile()
        {
            var user = _mapper.Map<User>(this.TheUser);
            await _Http.PutAsJsonAsync(this._navigationManager.BaseUri + "user", user);
            this.Message = "User updated successful!";
            this.Display = "block";
        }

        public Task GetUser()
        {
            throw new System.NotImplementedException();
        }

        public async Task GetUsers()
        {
            var items = await _Http.GetFromJsonAsync<List<User>>(_navigationManager.BaseUri + "user");
            this.users = items;
        }

        public Task DeleteUser()
        {
            throw new System.NotImplementedException();
        }

    }
}