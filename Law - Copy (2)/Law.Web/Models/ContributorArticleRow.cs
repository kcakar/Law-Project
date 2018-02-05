using Law.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law.Web.Models
{
    public class ContributorArticleRow
    {
        public string Title { get; set; }
        public string BodyPreview { get; set; }
        public DateTime CreationDate { get; set; }
        public int ViewCount { get; set; }
        public string ID { get; set; }

        public ContributorArticleRow(Article article)
        {
            this.ID = article.ID;
            this.Title = article.Title;
            this.BodyPreview = article.BodyPreview;
            this.CreationDate = article.CreationDate;
            this.ViewCount = article.ViewCount;
        }
    }
}
