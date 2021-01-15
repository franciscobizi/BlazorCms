using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlazorCms.Shared;
using MediatR;
using BlazorCms.Server.CQRS.Queries;
using BlazorCms.Server.CQRS.Commands;
using BlazorCms.Server.CQSR.Queries;
using BlazorCms.Server.CQSR.Commands;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Authentication.Google;

namespace BlazorCms.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _imediator;

        public UserController(IMediator imediator)
        {
            _imediator = imediator;
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
        {
            var result = await _imediator.Send(command);
            return CreatedAtAction("GetUser", new {userId = result.UserId},result);
        }

        [HttpPut("")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserCommand command)
        {
            var result = await _imediator.Send(command);
            return CreatedAtAction("GetUser", new {userId = result.UserId},result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var query = new GetAllUsersQuery();
            var result = await _imediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUser( int userId)
        {
            var query = new GetUserByIdQuery(userId);
            var result = await _imediator.Send(query);
            return result != null ? (IActionResult) Ok(result) : NotFound();
        }
        

        [HttpGet("getcurrentuser")]
        public async Task<IActionResult> GetCurrentUser()
        {
            bool IsAuthenticated = User.Identity.IsAuthenticated;
            string UserEmail = User.FindFirstValue(ClaimTypes.Email);

            var query = new GetCurrentUserQuery(IsAuthenticated, UserEmail);
            var currentUser = await _imediator.Send(query);
            return currentUser != null ? (IActionResult) Ok(currentUser) : NotFound();
        }

        [HttpPost("signin")]
        public async Task<IActionResult> SignInUser(SignInUserCommand command)
        {
            var result = await _imediator.Send(command);

            if (result != null)
            {
                //create a claim
                var claim = new Claim(ClaimTypes.Email, result.UserEmail);
                //create claimsIdentity
                var claimsIdentity = new ClaimsIdentity(new[] { claim }, "serverAuth");
                //create claimsPrincipal
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                //Sign In User
                await HttpContext.SignInAsync(claimsPrincipal);
            }

            return result != null ? (IActionResult) Ok(result) : NotFound();
        }

        [HttpGet("signout")]
        public async Task<ActionResult<String>> SignOutUser()
        {
            await HttpContext.SignOutAsync();
            return "Success";
        }

        // Authentication with exteranl APIs
        [HttpGet("FacebookSignIn")]
        public async Task FacebookSignIn()
        {
            await HttpContext.ChallengeAsync(FacebookDefaults.AuthenticationScheme, 
                new AuthenticationProperties { RedirectUri = "/bz-admin/profile" });
        }

        [HttpGet("GoogleSignIn")]
        public async Task GoogleSignIn()
        {
            await HttpContext.ChallengeAsync(GoogleDefaults.AuthenticationScheme, 
                new AuthenticationProperties { RedirectUri = "/bz-admin/profile" });
        }
    }
}
