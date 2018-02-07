using System;
using System.Collections.Generic;
using System.Text;

namespace Law.Models
{
    public class ArticleAddEditModel
    {
        public ArticleAddEditModel()
        {
            this.ID = Guid.NewGuid().ToString();
            this.CreationDate = DateTime.Now;
            this.paragraphs = new List<ArticleParagraphRow>();
        }

        public ArticleAddEditModel(Article article,List<ArticlePiece> articlePieces,Contributor contributor,PracticeArea practiceArea)
        {
            this.ID = article.ID;
            this.title = article.Title;
            this.contributorID = article.ContributorID;
            this.practiceAreaID = article.PracticeAreaID;
            this.preview = article.BodyPreview;
            this.paragraphs = new List<ArticleParagraphRow>();
            foreach (ArticlePiece piece in articlePieces)
            {
                this.paragraphs.Add(new ArticleParagraphRow()
                {
                    ID=piece.ID,
                    content = piece.Paragraph,
                    imagePosition = piece.GetImageString(piece.ImagePosition),
                    imageURL = piece.ImageUrl,
                    title = piece.Title
                });
            }
            this.tags = article.Tags;
            this.contributor = contributor;
            this.practiceArea = practiceArea;
            this.CreationDate = article.CreationDate;
        }

        public string ID { get; set; }
        public string title { get; set; }
        public string contributorID { get; set; }
        public string practiceAreaID { get; set; }
        public string preview { get; set; }
        public List<ArticleParagraphRow> paragraphs { get; set; }
        public string tags { get; set; }
        public Contributor contributor { get; set; }
        public PracticeArea practiceArea { get; set; }
        public DateTime CreationDate { get; set; }
    }

    public class ArticleParagraphRow
    {
        public string ID { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string imageURL { get; set; }
        public string imagePosition { get; set; }
    }
}
