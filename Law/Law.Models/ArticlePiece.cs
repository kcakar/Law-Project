using System;
using System.Collections.Generic;
using System.Text;

namespace Law.Models
{
    public class ArticlePiece
    {
        public string ID { get; set; }
        public string ArticleId { get; set; }
        public string Title { get; set; }
        public string Paragraph { get; set; }
        public string ImageUrl { get; set; }
        public ImagePosition ImagePosition { get; set; }

        public ImagePosition SetImagePosition(string position)
        {
            switch (position)
            {
                case "left":
                    return ImagePosition.Left;
                case "mid":
                    return ImagePosition.Middle;
                case "right":
                    return ImagePosition.Right;
                default:
                    return ImagePosition.Left;
            }
        }
    }
}