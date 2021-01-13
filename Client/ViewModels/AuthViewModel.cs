using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorCms.Shared.Models;

namespace BlazorCms.ViewModels
{
    class AuthViewModel : IAuthViewModel
    {
        public long UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPass { get; set; }
        public string Message { get; set; } 

        public string Display { get; set; } = "none";

        private HttpClient _Http;

        public AuthViewModel()
        {

        }
        // injecting httpClient 
        public AuthViewModel(HttpClient httpClient)
        {
            _Http = httpClient;
        }

        public async Task signIn()
        {
            await _Http.PostAsJsonAsync<User>("user/signin", this);
            //LoadCurrentObject(user);
            
        }

        public async Task getCurrentUser()
        {
            User user = await _Http.GetFromJsonAsync<User>("user/" + this.UserId);
            LoadCurrentObject(user);
            
        }

        private void LoadCurrentObject(AuthViewModel AuthViewModel)
        {
            this.UserId = AuthViewModel.UserId;
            this.UserEmail = AuthViewModel.UserEmail;
            this.UserPass = AuthViewModel.UserPass;
            //add more fields
        }

        // convert model to viewmodel
        public static implicit operator AuthViewModel(User AuthViewModel)
        {
            return new AuthViewModel()
            {
                UserId = AuthViewModel.UserId,
                UserEmail = AuthViewModel.UserEmail,
                UserPass = AuthViewModel.UserPass
            };
        }

        // convert viewmodel to model
        public static implicit operator User(AuthViewModel AuthViewModel)
        {
            return new User()
            {
                UserId = AuthViewModel.UserId,
                UserEmail = AuthViewModel.UserEmail,
                UserPass = AuthViewModel.UserPass
            };
        }

    }
}