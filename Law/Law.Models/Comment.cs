using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Law.Models
{

    public class Comment
    {    
        public string ID { get; set; }
        public string Username { get; set; }
        public string Body { get; set; }
        public string ArticleId { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? CreationTime { get; set; }
    }
}
