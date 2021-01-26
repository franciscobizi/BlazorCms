using System.Collections.Generic;
using BlazorCms.Shared.Models;

namespace BlazorCms.Shared.Mapping
{
    public partial class PostResponse
    {
        public long PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostPermalink { get; set; }
        public string PostContent { get; set; }
        public string PostCategory { get; set; }
        public string PostThumbnail { get; set; }
        public long PostAuthor { get; set; }
        public string PostAuthorName { get; set; }
        public string PostCreated { get; set; }
        public string PostUpdated { get; set; }
    }

}