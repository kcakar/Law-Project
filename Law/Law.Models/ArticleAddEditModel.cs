using System.Collections.Generic;

namespace Law.Models
{
    public class ArticleAddEditModel
    {
        public ArticleAddEditModel()
        {
            this.paragraphs = new List<ArticleParagraphRow>();
        }

        public string title { get; set; }
        public string contributorID { get; set; }
        public List<ArticleParagraphRow> paragraphs { get; set; }
    }

    public class ArticleParagraphRow
    {
        public string title { get; set; }
        public string content { get; set; }
        public string imageURL { get; set; }
        public string imagePosition { get; set; }
    }
}
