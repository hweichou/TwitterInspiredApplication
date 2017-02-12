using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TwitterInspiredApplication.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int uid { get; set; }

        public string email { get; set; }
        public string password { get; set; }
        public string fb_access_token { get; set; }
        public string nickname { get; set; }
        public string mobile { get; set; }
        public DateTime timestamp { get; set; }

        public virtual ICollection<UserFollow> FollowBy { get; set; }
        public virtual ICollection<UserFollow> Following { get; set; }

        public virtual ICollection<Tweet> UserTweet { get; set; }

        public virtual ICollection<Mention> UserMention { get; set; }

        public virtual ICollection<TweetNotification> UserNotify { get; set; }

        public virtual ICollection<ReplyNotification> UserRNotify { get; set; }

        public User()
        {
            FollowBy = new List<UserFollow>();
            Following = new List<UserFollow>();
            UserTweet = new List<Tweet>();
            UserMention = new List<Mention>();
            UserNotify = new List<TweetNotification>();
        }
    }
}