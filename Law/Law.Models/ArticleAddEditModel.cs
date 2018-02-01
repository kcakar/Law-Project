using System.Collections.Generic;

namespace Law.Models
{
    public class ArticleAddEditModel
    {
        public ArticleAddEditModel()
        {
            this.paragraphs = new List<ArticleParagraphRow>();
        }

        public string ID { get; set; }
        public string title { get; set; }
        public string contributorID { get; set; }
        public string practiceAreaID { get; set; }
        public List<ArticleParagraphRow> paragraphs { get; set; }
        public string tags { get; set; }
        public bool isNew { get; set; } = true;
        public Contributor contributor { get; set; }
        public PracticeArea practiceArea { get; set; }
    }

    public class ArticleParagraphRow
    {
        public string title { get; set; }
        public string content { get; set; }
        public string imageURL { get; set; }
        public string imagePosition { get; set; }
    }
}
