using NewsFeed.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFeeds.Models
{
    public class Content
    {
        [Key]
        public int Id { get; set; }
        public int SourceId { get; set; }
        public string Title { get; set; }
        public string Display { get; set; }
        public string ImageName { get; set; }
        public DateTime Date { get; set; }

        public virtual Source Source { get; set; }
        [NotMapped]
        public virtual UserFeed UserFeed { get; set; }

    }
}