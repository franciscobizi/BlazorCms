using System.Threading.Tasks;
using BlazorCms.Shared.Models;

namespace BlazorCms.ViewModels
{
    public interface IProfileViewModel
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPass { get; set; }
        public string UserFname { get; set; }
        public string UserLname { get; set; }
        public string Message { get; set; }

        public string Display { get; set; } 

        public Task getProfile();
        public Task UpdateProfile();

    }
}