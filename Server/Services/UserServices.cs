using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCms.Server.Helpers;
using BlazorCms.Server.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BlazorCms.Server.Services
{
    public class UserServices : IUserServices
    {
        private readonly BlazorCmsContext _context;

        public UserServices(BlazorCmsContext context)
        {
            _context = context;
        }

        public async Task<User> CreateUserAsync(string UserEmail,
                                    string UserFname,
                                    string UserLname,
                                    string UserAvatar,
                                    string UserPass,
                                    string UserSource,
                                    string UserRegistered
                                )
        {
            DateTime today = DateTime.Now;

            User users = new User();

            users.UserEmail = UserEmail;
            users.UserFname = UserFname;
            users.UserLname = UserLname;
            users.UserPass = Utility.Encrypt(UserPass);

            if(UserSource != null )
            {
                users.UserSource = UserSource;
            }

            if(UserAvatar != null )
            {
                users.UserAvatar = UserAvatar;
            }

            users.UserRegistered = today.ToString("yyyy-MM-dd"); 

            await _context.AddAsync(users);
            await _context.SaveChangesAsync();

            return await Task.FromResult(users);
        }

        public async Task<User> UpdateUserAsync(int UserId, string UserFname, string UserLname)
        {
            User users = await _context.Users.Where(u => u.UserId == UserId).FirstOrDefaultAsync();
            users.UserFname = UserFname;
            users.UserLname = UserLname;

            await _context.SaveChangesAsync();

            return await Task.FromResult(users);
        }

        public async Task<User> GetCurrentUserAsync(bool IsAuthenticated, string UserEmail)
        {
            User currentUser = new User();
            if (IsAuthenticated)
            {
                currentUser.UserEmail = UserEmail;
                currentUser = await _context.Users.Where(u => u.UserEmail == currentUser.UserEmail).FirstOrDefaultAsync();

                if (currentUser == null)
                {
                    DateTime today = DateTime.Now;
                    currentUser = new User();
                    //currentUser.UserId = _context.Users.Max(user => user.UserId) + 1;
                    currentUser.UserEmail = UserEmail;
                    currentUser.UserPass = Utility.Encrypt(currentUser.UserEmail);
                    currentUser.UserSource = "EXTL";
                    currentUser.UserRegistered = today.ToString("yyyy-MM-dd");

                    _context.Users.Add(currentUser);
                    await _context.SaveChangesAsync();
                }
            }
            return await Task.FromResult(currentUser);
        }

        public async Task<User> GetUserAsync(int id)
        {
            var user =_context.Users.Where(u => u.UserId == id).FirstOrDefault();
            return await Task.FromResult(user);
        }

        public List<User> GetUsersAsync()
        {
            return _context.Users.ToList();
        }

        public async Task<User> SignInUser(string UserEmail, string UserPass)
        {
            UserPass = Utility.Encrypt(UserPass);
            User loggedInUser = await _context.Users.Where(u => u.UserEmail == UserEmail && u.UserPass == UserPass).FirstOrDefaultAsync();
            return loggedInUser;
        }
    }
}