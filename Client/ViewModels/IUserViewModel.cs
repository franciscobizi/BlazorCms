using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorCms.Shared.Models;

namespace BlazorCms.ViewModels
{
    public interface IUserViewModel
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
        public List<User> users { get ; set; }
        public User TheUser { get ; set; }
        public Task UpdateProfile();
        public Task GetUser();
        public Task GetUsers();
        public Task DeleteUser();

    }
}