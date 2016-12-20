﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace WindowsClient.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public Post() { }
    }
}