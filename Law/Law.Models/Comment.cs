using System;
using System.Collections.Generic;
using System.Text;

namespace Law.Models
{
    public class Comment
    {
        public string Username { get; set; }
        public string Body { get; set; }
        public string ArticleId { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
