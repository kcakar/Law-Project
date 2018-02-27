using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Law.Models
{
    [Table("Comment")]
    public class Comment
    {
        public string Username { get; set; }
        public string Body { get; set; }
        public string ArticleId { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
