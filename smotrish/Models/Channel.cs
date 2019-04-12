using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace smotrish.Models
{
    public class Channel
    {
        public int ChannelID { get; set; }
        [Required()]
        [StringLength(100, MinimumLength =2)]
        public string Name { get; set; }
    }
}