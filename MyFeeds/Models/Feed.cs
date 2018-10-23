using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFeeds.Models
{
    [Table("Feeds")]
    public class Feed
    {
        [Key]
        public int Id { get; set; }
        public virtual ContentType ContentType { get; set; }
        public virtual Content Content { get; set; }
        public virtual Source Source { get; set; }

        public int ContentTypeId { get; set; }
        public int ContentId { get; set; }
        public int SourceId { get; set; }

    }
}