using System.Collections.Generic;
using BlazorCms.Server.Models;
using MediatR;

namespace Server.CQSR.Queries
{
    public class SearchPostQuery : IRequest<List<Post>>
    {

        public string PostTitle { get; set; }
        public SearchPostQuery(string PostTitle)
        {
            this.PostTitle = PostTitle;
        }
    }
}