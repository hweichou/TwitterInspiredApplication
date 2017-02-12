using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TwitterInspiredApplication.Models
{
    public class HashtagRelation
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int hrid { get; set; }

        public int tid { get; set; }
        public int tagid { get; set; }

        [ForeignKey("tagid")]
        public Hashtag RelationHash { get; set; }

        [ForeignKey("tid")]
        public Tweet RelationTweet { get; set; }

    }
}