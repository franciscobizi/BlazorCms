using System.Threading;
using System.Threading.Tasks;
using BlazorCms.Server.Models;
using MediatR;
using BlazorCms.Server.Services;
using BlazorCms.Server.CQRS.Commands;
using Microsoft.Extensions.Logging;

namespace BlazorCms.Server.CQRS.Handlers
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, Post>
    {
        private readonly IPostServices _postServices;
        private readonly ILogger<CreatePostCommandHandler> _logger;

        public CreatePostCommandHandler(ILogger<CreatePostCommandHandler> logger, IPostServices postServices)
        {
            _logger = logger;
            _postServices = postServices;
        }

        public async Task<Post> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var post = await _postServices.CreatePostAsync(request.post);
            _logger.LogInformation($"Created new post {post.PostId}");
            return post;
        }
    }
}