using System;
using System.Collections.Generic;

namespace BlazorCms.Shared.Mapping
{
    public class UserResponse
    {

        public long UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPass { get; set; }
        public string UserSource { get; set; }
        public string UserFname { get; set; }
        public string UserLname { get; set; }
        public string UserAvatar { get; set; }
        public string UserRegistered { get; set; }

    }
}
