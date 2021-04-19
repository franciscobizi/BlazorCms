using System.Threading;
using System.Threading.Tasks;
using BlazorCms.Server.CQSR.Queries;
using BlazorCms.Server.Models;
using BlazorCms.Server.Services;
using MediatR;

namespace BlazorCms.Server.CQSR.Handlers
{
    public class GetCurrentUserHandler : IRequestHandler<GetCurrentUserQuery,User>
    {
        private readonly IUserServices _userServices;

        public GetCurrentUserHandler(IUserServices userServices)
        {
            _userServices = userServices;
        }

        public async Task<User> Handle(GetCurrentUserQuery request, CancellationToken cancellationToken)
        {
            return await _userServices.GetCurrentUserAsync(request._IsAuthenticated, request._UserEmail);
        }
    }
}