using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TwitterInspiredApplication.Models
{
    public class Reply
    {
        [Key]
        public int rid { get; set; }

        public int tid { get; set; }
        public string message { get; set; }
        public DateTime timestamp { get; set; }
        
        [ForeignKey("tid")]
        public Tweet ReplyTweet { get; set; }

        public virtual ICollection<ReplyNotification> ReplyNotify { get; set; }

        public Reply()
        {
            ReplyNotify = new List<ReplyNotification>();
        }
    }
}