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

            User users = new User();

            users.UserEmail = user.UserEmail;
            users.UserFname = user.UserFname;
            users.UserLname = user.UserLname;
            users.UserPass = Utility.Encrypt(user.UserPass);
            users.UserSource = "Local";
            users.UserStatus = "allowed";
            users.UserRegistered = today.ToString("dd/MM/yyyy");
            users.UserLogged = today.ToString(); 

            await _context.AddAsync(users);
            await _context.SaveChangesAsync();

            return await Task.FromResult(users);
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            User users = await _context.Users.Where(u => u.UserId == user.UserId).FirstOrDefaultAsync();
            users.UserFname = user.UserFname;
            users.UserLname = user.UserLname;
            //users.UserPass = Utility.Encrypt("1111");

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

        public List<User> GetUsersAsync()
        {
            return _context.Users.ToList();
        }

        public async Task<User> SignInUser(User user)
        {
            user.UserPass = Utility.Encrypt(user.UserPass);
            User loggedInUser = await _context.Users.Where(u => u.UserEmail == user.UserEmail && u.UserPass == user.UserPass).FirstOrDefaultAsync();
            loggedInUser.UserLogged = DateTime.Now.ToString();
            await _context.SaveChangesAsync();
            return loggedInUser;
        }
    }
}