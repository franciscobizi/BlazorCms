using BlazorCms.Server.Models;
using MediatR;

namespace BlazorCms.Server.CQRS.Commands
{
    public class CreateUserCommand : IRequest<User>
    {
        public long UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPass { get; set; }
        public string UserSource { get; set; }
        public string UserFname { get; set; }
        public string UserLname { get; set; }
        public string UserAvatar { get; set; }
        public string UserRegistered { get; set; }

    }
}