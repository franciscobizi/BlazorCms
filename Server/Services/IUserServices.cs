
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorCms.Server.Models;

namespace BlazorCms.Server.Services
{
    public interface IUserServices
    {
        List<User> GetUsersAsync();
        Task<User> GetUserAsync(int id);
        Task<User> SignInUser(string UserEmail, string UserPass);
        Task<User> GetCurrentUserAsync(bool IsAuthenticated, string UserEmai);
        Task<User> CreateUserAsync(
                                    string UserEmail,
                                    string UserFname,
                                    string UserLname,
                                    string UserAvatar,
                                    string UserPass,
                                    string UserSource,
                                    string UserRegistered
                                );


    }
}