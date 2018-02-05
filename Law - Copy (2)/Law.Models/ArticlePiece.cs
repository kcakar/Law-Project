using System;
using System.Collections.Generic;
using System.Text;

namespace Law.Models
{
    public class ArticlePiece
    {
        public ArticlePiece() { }
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

        public string GetImageString(ImagePosition ImagePosition)
        {
            switch (ImagePosition)
            {
                case ImagePosition.Left:
                    return "left";
                case ImagePosition.Middle:
                    return "mid";
                case ImagePosition.Right:
                    return "right";
                default:
                    return "left";
            }
        }
    }
}