using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorCms.Server.Models;
using BlazorCms.Server.Services;
using MediatR;
using Server.CQSR.Queries;

namespace Server.CQSR.Handlers
{
    public class SearchPostHandler : IRequestHandler<SearchPostQuery, List<Post>>
    {
        private readonly IPostServices _postServices;
        public SearchPostHandler(IPostServices postServices)
        { 
            _postServices = postServices;
        }

        public async Task<List<Post>> Handle(SearchPostQuery request, CancellationToken cancellationToken)
        {
            return await _postServices.Search(request.PostTitle);
        }
    }
}