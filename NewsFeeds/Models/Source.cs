using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFeeds.Models
{
    public class Source
    {
        [Key]
        public int Id { get; set; }
        public string Origin { get; set; }

    }
}