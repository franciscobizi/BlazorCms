using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCms.Server.Helpers;
using BlazorCms.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCms.Server.Services
{
    public class UserServices : IUserServices
    {
        private readonly blazorcmsContext _context;

        public UserServices(blazorcmsContext context)
        {
            _context = context;
        }

        public async Task<User> CreateUserAsync(User user)
        {
            DateTime today = DateTime.Now;

            user.UserPass = Utility.Encrypt(user.UserPass);
            user.UserSource = "Local";
            user.UserStatus = "allowed";
            user.UserRegistered = today.ToString("dd/MM/yyyy");
            user.UserLogged = today.ToString(); 

            await _context.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            var users = await _context.Users.Where(u => u.UserId == user.UserId).FirstOrDefaultAsync();
            users.UserFname = Utility.Ucfirst(user.UserFname);
            users.UserLname = Utility.Ucfirst(user.UserLname);
            if(!string.IsNullOrEmpty(user.UserRoles))
            {
                users.UserRoles = user.UserRoles;
            }

            await _context.SaveChangesAsync();

            return users;
        }

        public async Task<User> GetCurrentUserAsync(bool IsAuthenticated, string UserEmail)
        {
            var currentUser = new User();
            if (IsAuthenticated)
            {
                currentUser.UserEmail = UserEmail;
                currentUser = await _context.Users.Where(u => u.UserEmail == currentUser.UserEmail).FirstOrDefaultAsync();

                if (currentUser == null)
                {
                    DateTime today = DateTime.Now;
                    currentUser = new User();
                    currentUser.UserFname = Utility.Ucfirst(UserEmail.Split('@')[0]);
                    currentUser.UserLname = currentUser.UserFname;
                    currentUser.UserEmail = UserEmail;
                    currentUser.UserPass = Utility.Encrypt(currentUser.UserFname);
                    currentUser.UserSource = "EXTL";
                    currentUser.UserStatus = "allowed";
                    currentUser.UserRegistered = today.ToString("dd/MM/yyyy");
                    currentUser.UserLogged = DateTime.Now.ToString();

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

        public async Task<List<User>> GetUsersAsync()
        {
            var users = _context.Users.ToList();
            return await Task.FromResult(users);
        }

        public async Task<User> SignInUser(User user)
        {
            user.UserPass = Utility.Encrypt(user.UserPass);
            var loggedInUser = await _context.Users.Where(u => u.UserEmail == user.UserEmail && u.UserPass == user.UserPass).FirstOrDefaultAsync();
            loggedInUser.UserLogged = DateTime.Now.ToString();
            await _context.SaveChangesAsync();
            return loggedInUser;
        }
    }
}