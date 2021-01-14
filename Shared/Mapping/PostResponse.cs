using System.Collections.Generic;

namespace BlazorCms.Shared.Mapping
{
    public class PostResponse
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostPermalink { get; set; }
        public string PostContent { get; set; }
        public string PostThumbnail { get; set; }
        public int PostAuthor { get; set; }
        public string PostAuthorName { get; set; }
        public string PostCreated { get; set; }
        public string PostUpdated { get; set; }
    }

    /* public void mappItems(posts)
    {
            List<this> Items = new List<this>();

            foreach(var post in posts)
            {
                var author = post.PostAuthorNavigation.UserFname + " " + post.PostAuthorNavigation.UserLname;
                Items.Add(new PostResponse()
                {
                    PostId = post.PostId,
                    PostTitle = post.PostTitle,
                    PostContent = post.PostContent,
                    PostThumbnail = post.PostThumbnail,
                    PostAuthor =  post.PostAuthor,
                    PostAuthorName = author,
                    PostCreated = post.PostCreated,
                    PostUpdated = post.PostUpdated
                });
            }

            return Items;
    } */
}