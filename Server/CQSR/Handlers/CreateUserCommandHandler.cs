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
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, User>
    {
        private readonly IUserServices _userServices;
        private readonly ILogger<CreateUserCommandHandler> _logger;

        public CreateUserCommandHandler(ILogger<CreateUserCommandHandler> logger, IUserServices userServices)
        {
            _logger = logger;
            _userServices = userServices;
        }

        public async Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userServices.CreateUserAsync(request.user);
            _logger.LogInformation($"Created new user {user.UserId}");
            return user;
        }
    }
}