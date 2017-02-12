using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TwitterInspiredApplication.Models
{
    public class ReplyNotification
    {
        [Key]
        public int rnid { get; set; }
        public int rid { get; set; }
        public int uid { get; set; }
        public bool read { get; set; }
        public DateTime timestamp { get; set; }

        [ForeignKey("rid")]
        public Reply NotifyReply { get; set; }

        [ForeignKey("uid")]
        public User NotifyUser { get; set; }

    }
}