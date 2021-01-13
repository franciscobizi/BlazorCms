using BlazorCms.Server.Models;
using MediatR;

namespace BlazorCms.Server.CQRS.Commands
{
    public class CreatePostCommand : IRequest<Post>
    {
        public long PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostPermalink { get; set; }
        public string PostContent { get; set; }
        public string PostThumbnail { get; set; }
        public long PostAuthor { get; set; }
        public string PostCreated { get; set; }
        public string PostUpdated { get; set; }

    }
}