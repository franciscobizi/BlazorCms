using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorCms.Shared.Models
{
    public partial class Post
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostPermalink { get; set; }
        public string PostContent { get; set; }
        public string PostThumbnail { get; set; }
        public int PostAuthor { get; set; }
        public string PostCreated { get; set; }
        public string PostUpdated { get; set; }

        public virtual User PostAuthorNavigation { get; set; }
    }
}
