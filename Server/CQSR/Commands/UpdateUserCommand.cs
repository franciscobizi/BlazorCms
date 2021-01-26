using BlazorCms.Server.Models;
using MediatR;

namespace BlazorCms.Server.CQRS.Commands
{
    public class UpdateUserCommand : IRequest<User>
    {
        public User user = new User();

    }
}