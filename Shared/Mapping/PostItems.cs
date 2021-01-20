using System.Collections.Generic;
using BlazorCms.Shared.Mapping;

namespace Shared.Mapping
{
    public class PostItems
    {
        public List<PostResponse> Items { get; set; }
        public string Count { get; set; }
    }
}