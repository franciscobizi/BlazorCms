using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorCms.Shared.Models;

namespace BlazorCms.ViewModels
{
    public interface IAuthViewModel
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPass { get; set; }

        public Task getCurrentUser();
        public Task signIn();

    }
}