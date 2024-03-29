using System.Threading;
using System.Threading.Tasks;
using BlazorCms.Server.Models;
using MediatR;
using BlazorCms.Server.Services;
using BlazorCms.Server.CQRS.Commands;
using Microsoft.Extensions.Logging;

namespace BlazorCms.Server.CQRS.Handlers
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, User>
    {
        private readonly IUserServices _userServices;
        private readonly ILogger<UpdateUserCommandHandler> _logger;

        public UpdateUserCommandHandler(ILogger<UpdateUserCommandHandler> logger, IUserServices userServices)
        {
            _logger = logger;
            _userServices = userServices;
        }

        public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userServices.UpdateUserAsync(request.user);
            _logger.LogInformation($"Updated new user {user.UserId}");
            return user;
        }
    }
}