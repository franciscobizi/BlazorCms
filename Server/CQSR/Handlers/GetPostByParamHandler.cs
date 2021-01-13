using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorCms.Server.Models;
using MediatR;
using BlazorCms.Server.Services;
using BlazorCms.Server.CQRS.Queries;

namespace BlazorCms.Server.CQRS.Handlers
{
    public class GetPostByParamHandler : IRequestHandler<GetPostByParamQuery,Post>
    {
        private readonly IPostServices _postServices;

        public GetPostByParamHandler(IPostServices postServices)
        {
            _postServices = postServices;
        }

        public async Task<Post> Handle(GetPostByParamQuery request, CancellationToken cancellationToken)
        {
            var post = await _postServices.GetPostByParamAsync(request.param);
            return post == null ? null : post;
        }
    }
}