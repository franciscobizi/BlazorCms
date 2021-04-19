using System.Threading;
using System.Threading.Tasks;
using BlazorCms.Server.CQSR.Commands;
using BlazorCms.Server.CQSR.Queries;
using BlazorCms.Server.Models;
using BlazorCms.Server.Services;
using MediatR;

namespace BlazorCms.Server.CQSR.Handlers
{
    public class DeletePostHandler : IRequestHandler<DeletePostQuery, Post>
    {
        private readonly IPostServices _postServices;

        public DeletePostHandler(IPostServices postServices)
        {
            _postServices = postServices;
        }

        public async Task<Post> Handle(DeletePostQuery request, CancellationToken cancellationToken)
        {
            return await _postServices.DeletePostAsync(request.PostId); 
        }
    }
}