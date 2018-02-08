using Law.Core;
using Law.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law.Web.Models
{
    public class ArticleViewModel
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
        public int ViewCount { get; set; }
        public string ContributorName { get; set; }
        public string ContributorImage { get; set; }
        public string ArticleBody { get; set; }
        public string 
        public List<LatestArticleRow> LatestArticles { get; set; }
        public List<LatestContributorsRow> LatestContributors { get; set; }
        
        public ArticleViewModel(Article Article)
        {
            this.LatestArticles = new List<LatestArticleRow>();
            foreach(Article article in ArticleCore.GetMostRecentArticles(5))
            {
                LatestArticles.Add(new LatestArticleRow(article.ID,article.Title,article.CreationDate));
            }

            this.LatestContributors = new List<LatestContributorsRow>();
            foreach (Contributor latestContributor in ContributorCore.GetLatestContributors(5))
            {
                LatestContributors.Add(new LatestContributorsRow(latestContributor.ID, latestContributor.Name, latestContributor.TotalContributions,latestContributor.ImageURL));
            }
            AffiliateName =AffiliateCore.GetAffiliatesById( Article.AffiliateID);
            Article.ViewCount = Article.ViewCount + 1;
            ID = Article.ID;
            Title = Article.Title;
            CreationDate = Article.CreationDate;
            ViewCount = Article.ViewCount;//todo dbden arttır
            ArticleBody = GetArticleBody(ArticleCore.GetArticlePiecesByArticleId(Article.ID));

            Contributor contributor = ContributorCore.GetContributorsById(Article.ContributorID);
            ContributorName = contributor.Name;
            ContributorImage = contributor.ImageURL;
        }

        public string GetArticleBody(List<ArticlePiece> pieces)
        {
            string result = "";

            foreach(ArticlePiece piece in pieces)
            {
                if(!string.IsNullOrEmpty(piece.Title))
                {
                    result += "<h2>"+piece.Title+"</h2>";
                }

                if (!string.IsNullOrEmpty(piece.Paragraph))
                {
                    result += "<p>" + piece.Paragraph + "</p>";
                }
                if (!string.IsNullOrEmpty(piece.ImageUrl))
                {
                    result += "<img src='" + piece.ImageUrl.GetImageUrl() + "'/>";
                }
            }

            return result;
        }
    }
}
