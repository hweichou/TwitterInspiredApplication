using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TwitterInspiredApplication.Models
{
    public class Tweet
    {
        [Key]
        public int tid { get; set; }

        public int uid { get; set; }
        public string message { get; set; }
        public DateTime timestamp { get; set; }

        [ForeignKey("uid")]
        public User TweetUser { get; set; }

        public virtual ICollection<Mention> MentionTweet { get; set; }
        public virtual ICollection<TweetNotification> TweetNotify { get; set; }
        public virtual ICollection<Reply> TweetReply { get; set; }
        public virtual ICollection<HashtagRelation> TweetRelation { get; set; }

        public Tweet()
        {
            MentionTweet = new List<Mention>();
            TweetNotify = new List<TweetNotification>();
            TweetReply = new List<Reply>();
            TweetRelation = new List<HashtagRelation>();
        }
    }
}