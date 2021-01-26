using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorCms.Shared.Models;

namespace BlazorCms.ViewModels
{
    class ProfileViewModel : IProfileViewModel
    {
        public long UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPass { get; set; }
        public string UserFname { get; set; }
        public string UserLname { get; set; }
        public string Message { get; set; } 

        public string Display { get; set; } = "none";

        private HttpClient _Http;

        public ProfileViewModel()
        {

        }
        // injecting httpClient 
        public ProfileViewModel(HttpClient httpClient)
        {
            _Http = httpClient;
        }

        public async Task getProfile()
        {
            User user = await _Http.GetFromJsonAsync<User>("user/" + this.UserId);
            LoadCurrentObject(user);
            
        }

        private void LoadCurrentObject(ProfileViewModel profileViewModel)
        {
            this.UserId = profileViewModel.UserId;
            this.UserEmail = profileViewModel.UserEmail;
            this.UserPass = profileViewModel.UserPass;
            this.UserFname = profileViewModel.UserFname;
            this.UserLname = profileViewModel.UserLname;
            //add more fields
        }

        public async Task UpdateProfile()
        {
            User user = this;
            await _Http.PutAsJsonAsync("user/", user);
            this.Message = "Profile updated successful!";
            this.Display = "block";
        }

        // convert model to viewmodel
        public static implicit operator ProfileViewModel(User profileViewModel)
        {
            return new ProfileViewModel()
            {
                UserId = profileViewModel.UserId,
                UserEmail = profileViewModel.UserEmail,
                UserPass = profileViewModel.UserPass,
                UserFname = profileViewModel.UserFname,
                UserLname = profileViewModel.UserLname
            };
        }

        // convert viewmodel to model
        public static implicit operator User(ProfileViewModel profileViewModel)
        {
            return new User()
            {
                UserId = profileViewModel.UserId,
                UserEmail = profileViewModel.UserEmail,
                UserPass = profileViewModel.UserPass,
                UserFname = profileViewModel.UserFname,
                UserLname = profileViewModel.UserLname
            };
        }

    }
}