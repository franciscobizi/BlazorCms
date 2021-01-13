using System.Collections.Generic;
using BlazorCms.Server.Models;
using MediatR;

namespace BlazorCms.Server.CQRS.Queries
{
    public class GetAllPostsQuery : IRequest<List<Post>>
    {

    }
}