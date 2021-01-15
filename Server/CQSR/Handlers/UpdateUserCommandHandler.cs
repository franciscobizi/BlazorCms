using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorCms.Server.Models;
using BlazorCms.Server.CQRS.Queries;
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
            var user = await _userServices.UpdateUserAsync(
                                            request.UserId,
                                            request.UserFname,
                                            request.UserLname
                                            );
            _logger.LogInformation($"Updated new user {user.UserId}");
            return user;
        }
    }
}