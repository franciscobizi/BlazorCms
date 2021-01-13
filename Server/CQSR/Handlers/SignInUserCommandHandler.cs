using System.Threading;
using System.Threading.Tasks;
using BlazorCms.Server.CQSR.Commands;
using BlazorCms.Server.Models;
using BlazorCms.Server.Services;
using MediatR;

namespace Server.CQSR.Handlers
{
    public class SignInUserCommandHandler : IRequestHandler<SignInUserCommand,User>
    {
        private readonly IUserServices _userServices;

        public SignInUserCommandHandler(IUserServices userServices)
        {
            _userServices = userServices;
        }

        public async Task<User> Handle(SignInUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userServices.SignInUser(request.UserEmail, request.UserPass);
            return user;
        }
    }
}