using BlazorCms.Server.Models;
using MediatR;

namespace BlazorCms.Server.CQRS.Commands
{
    public class CreateUserCommand : IRequest<User>
    {
        public User user = new User();

    }
}