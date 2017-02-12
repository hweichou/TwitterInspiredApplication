using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TwitterInspiredApplication.Models
{
    public class UserFollow
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int uid { get; set; }
        public int followId { get; set; }
        public bool email { get; set; }
        public DateTime timestamp { get; set; }

        [ForeignKey("uid")]
        public virtual User MainUser { get; set; }

        [ForeignKey("followId")]
        public virtual User FollowingUser { get; set; }

    }
}