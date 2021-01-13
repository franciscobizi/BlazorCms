using BlazorCms.Server.Models;
using MediatR;

namespace BlazorCms.Server.CQSR.Queries
{
    public class DeletePostQuery : IRequest<Post>
    {
        public int PostId { get; set; }

        public DeletePostQuery(int id)
        {
            PostId = id;
        }
    }
}