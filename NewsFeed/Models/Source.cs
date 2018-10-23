using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFeeds.Models
{
    public class Source
    {
        [Key]
        public int Id { get; set; }
        public string Origin { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string ImageName { get; set; }

    }
}