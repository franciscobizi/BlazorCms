using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
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
        public string UserRegistered { get; set; }
        public string UserLogged { get; set; }
        public string Message { get; set; } 

        public string Display { get; set; } = "none";
        public List<User> users { get ; set; }

        private readonly HttpClient _Http;
        private readonly NavigationManager _navigationManager;

        public UserViewModel()
        {

        }
        // injecting httpClient 
        public UserViewModel(HttpClient httpClient, NavigationManager navigationManager)
        {
            _Http = httpClient;
            _navigationManager = navigationManager;
        }

        private void LoadCurrentObject(UserViewModel UserViewModel)
        {
            this.UserId = UserViewModel.UserId;
            this.UserEmail = UserViewModel.UserEmail;
            this.UserFname = UserViewModel.UserFname;
            this.UserLname = UserViewModel.UserLname;
            this.UserSource = UserViewModel.UserSource;
            this.UserRegistered = UserViewModel.UserRegistered;
            this.UserLogged = UserViewModel.UserLogged;
            //add more fields
        }

        public async Task UpdateProfile()
        {
            User user = this;
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
            var items = await _Http.GetStringAsync(_navigationManager.BaseUri + "user");
            this.users = JsonConvert.DeserializeObject<List<User>>(items);
        }

        public Task DeleteUser()
        {
            throw new System.NotImplementedException();
        }

        // convert model to viewmodel
        public static implicit operator UserViewModel(User UserViewModel)
        {
            return new UserViewModel()
            {
                UserId = UserViewModel.UserId,
                UserEmail = UserViewModel.UserEmail,
                UserFname = UserViewModel.UserFname,
                UserLname = UserViewModel.UserLname,
                UserSource = UserViewModel.UserSource,
                UserRegistered = UserViewModel.UserRegistered,
                UserLogged = UserViewModel.UserLogged
            };
        }

        // convert viewmodel to model
        public static implicit operator User(UserViewModel UserViewModel)
        {
            return new User()
            {
                UserId = UserViewModel.UserId,
                UserEmail = UserViewModel.UserEmail,
                UserFname = UserViewModel.UserFname,
                UserLname = UserViewModel.UserLname,
                UserSource = UserViewModel.UserSource,
                UserRegistered = UserViewModel.UserRegistered,
                UserLogged = UserViewModel.UserLogged
            };
        }

    }
}