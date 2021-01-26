using BlazorCms.Server.Models;
using MediatR;

namespace BlazorCms.Server.CQSR.Commands
{
    public class SignInUserCommand : IRequest<User>
    {
        public User user = new User();
    }
}