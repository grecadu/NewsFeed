﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFeeds.Models
{
    public class Content
    {
        [Key]
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string NewsContent { get; set; }
        public DateTime Date { get; set; }

    }
}