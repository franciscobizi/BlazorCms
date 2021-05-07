using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorCms.Shared.Models;

namespace BlazorCms.ViewModels
{
    public interface IAuthViewModel
    {
        public long UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPass { get; set; }
        public string Message { get; set; } 
        public string Display { get; set; }
        public User TheUser { get; set; }

        public Task getCurrentUser();
        public Task signIn();
        public void FacebookSignIn();

        public void GoogleSignIn();

    }
}