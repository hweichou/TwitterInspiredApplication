using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TwitterInspiredApplication.Models
{
    public class TweetNotification
    {
        [Key]
        public int tnid { get; set; }

        public int tid { get; set; }
        public int uid { get; set; }
        public bool read { get; set; }
        public DateTime timestamp { get; set; }

        [ForeignKey("tid")]
        public Tweet NotifyTweet { get; set; }

        [ForeignKey("uid")]
        public User NotifyUser { get; set; }

    }
}