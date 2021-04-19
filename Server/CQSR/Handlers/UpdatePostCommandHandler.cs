using System.Threading;
using System.Threading.Tasks;
using BlazorCms.Server.Models;
using MediatR;
using BlazorCms.Server.Services;
using BlazorCms.Server.CQRS.Commands;
using Microsoft.Extensions.Logging;

namespace BlazorCms.Server.CQRS.Handlers
{
    public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand, Post>
    {
        private readonly IPostServices _postServices;
        private readonly ILogger<UpdatePostCommandHandler> _logger;

        public UpdatePostCommandHandler(ILogger<UpdatePostCommandHandler> logger, IPostServices postServices)
        {
            _logger = logger;
            _postServices = postServices;
        }

        public async Task<Post> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {
            var post = await _postServices.UpdatePostAsync(request.post);
            _logger.LogInformation($"Updated new Post {post.PostId}");
            return post;
        }
    }
}