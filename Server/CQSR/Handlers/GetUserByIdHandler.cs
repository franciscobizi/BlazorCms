using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorCms.Server.Models;
using MediatR;
using BlazorCms.Server.Services;
using BlazorCms.Server.CQRS.Queries;

namespace BlazorCms.Server.CQRS.Handlers
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery,User>
    {
        private readonly IUserServices _userServices;

        public GetUserByIdHandler(IUserServices userServices)
        {
            _userServices = userServices;
        }

        public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _userServices.GetUserAsync(request.userId);
            return user == null ? null : user;
        }
    }
}