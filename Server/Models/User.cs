using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorCms.Server.Models
{
    public partial class User
    {
        public User()
        {
            Posts = new HashSet<Post>();
        }

        public long UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPass { get; set; }
        public string UserSource { get; set; }
        public string UserRoles { get; set; }
        public string UserFname { get; set; }
        public string UserLname { get; set; }
        public string UserAvatar { get; set; }
        public string UserStatus { get; set; }
        public string UserRegistered { get; set; }
        public string UserLogged { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
