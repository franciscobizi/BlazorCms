using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorCms.Server.Models;

namespace BlazorCms.Server.Services
{
    public interface IUserServices
    {
        Task<List<User>> GetUsersAsync();
        Task<User> GetUserAsync(int id);
        Task<User> SignInUser(User user);
        Task<User> GetCurrentUserAsync(bool IsAuthenticated, string UserEmai);
        Task<User> UpdateUserAsync(User user);
        Task<User> CreateUserAsync(User user);


    }
}