using BlazorCms.Server.Models;
using MediatR;

namespace BlazorCms.Server.CQSR.Commands
{
    public class SignInUserCommand : IRequest<User>
    {
        public string UserEmail { get; set; }
        public string UserPass { get; set; }
    }
}