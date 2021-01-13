using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorCms.Server.Models;
using BlazorCms.Server.CQRS.Queries;
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
            var post = await _postServices.UpdatePostAsync( 
                                            request.PostId,
                                            request.PostTitle, 
                                            request.PostPermalink, 
                                            request.PostContent, 
                                            request.PostThumbnail, 
                                            request.PostAuthor, 
                                            request.PostCreated, 
                                            request.PostUpdated
                                            );
            _logger.LogInformation($"Updated new Post {post.PostId}");
            return post;
        }
    }
}