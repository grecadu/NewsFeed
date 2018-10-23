using MyFeeds.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewsFeed.Models
{
    public class UserFeed
    {
        [Key]
        public int Id { get; set; }
        public int SourceId { get; set; }
        public string UserId { get; set; }

        public Source Source { get; set; }
    }
}