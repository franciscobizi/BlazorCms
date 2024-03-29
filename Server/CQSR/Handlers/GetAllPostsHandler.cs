using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorCms.Server.Models;
using BlazorCms.Server.CQRS.Queries;
using MediatR;
using BlazorCms.Server.Services;
using BlazorCms.Shared.Mapping;
using AutoMapper;

namespace BlazorCms.Server.CQRS.Handlers
{
    public class GetAllPostsHandler : IRequestHandler<GetAllPostsQuery, List<Post>>
    {
        private readonly IPostServices _postServices;

        public GetAllPostsHandler(IPostServices postServices)
        {
            _postServices = postServices;
        }

        public async Task<List<Post>> Handle(GetAllPostsQuery request, CancellationToken cancellationToken)
        {
            return await _postServices.GetPostsAsync();
        }

    }
}