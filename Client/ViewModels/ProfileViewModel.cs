using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using AutoMapper;
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
        public User TheUser { get; set;}

        private HttpClient _Http;
        private readonly IMapper _mapper;
        public ProfileViewModel()
        {

        }
        // injecting httpClient 
        public ProfileViewModel(HttpClient httpClient, IMapper mapper)
        {
            _Http = httpClient;
            _mapper = mapper;
            this.TheUser = new User();
        }

        public async Task getProfile()
        {
            var user = await _Http.GetFromJsonAsync<User>("user/" + this.UserId);
            this.TheUser = user;
            
        }

        public async Task UpdateProfile()
        {
            var user = _mapper.Map<User>(this.TheUser);

            await _Http.PutAsJsonAsync("user/", user);
            this.Message = "Profile updated successful!";
            this.Display = "block";
        }

    }
}