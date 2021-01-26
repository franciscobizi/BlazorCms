using BlazorCms.Server.Models;
using MediatR;

namespace BlazorCms.Server.CQRS.Commands
{
    public class CreatePostCommand : IRequest<Post>
    {
        public Post post = new Post();

    }
}