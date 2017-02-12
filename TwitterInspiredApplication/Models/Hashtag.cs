using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TwitterInspiredApplication.Models
{
    public class Hashtag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int hid { get; set; }
        
        public string tagname { get; set; }

        public virtual ICollection<HashtagRelation> HashtagR { get; set; }

        public Hashtag()
        {
            HashtagR = new List<HashtagRelation>();
        }

    }
}