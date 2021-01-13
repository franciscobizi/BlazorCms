using BlazorCms.Server.Models;
using MediatR;

namespace BlazorCms.Server.CQSR.Commands
{
    public class DeletePostCommand : IRequest<Post>
    {
        public int PostId { get; set; }
    }
}