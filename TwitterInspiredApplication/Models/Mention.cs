using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TwitterInspiredApplication.Models
{
    public class Mention
    {
        [Key]
        public int mid { get; set; }

        public int tid { get; set; }
        public int uid { get; set; }
        public DateTime timestamp { get; set; }

        [ForeignKey("uid")]
        public User MentionedUser { get; set; }

        [ForeignKey("tid")]
        public Tweet MentionedTweet { get; set; }

    }
}