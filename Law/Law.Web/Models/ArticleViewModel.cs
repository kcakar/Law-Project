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

            ID = Article.ID;
            Title = Article.Title;
            CreationDate = Article.CreationDate;
            ViewCount = Article.ViewCount;
            ArticleBody = Article.Body;

            Contributor contributor = ContributorCore.GetContributorsById(Article.ContributorID);
            ContributorName = contributor.Name;
            ContributorImage = contributor.ImageURL;
        }
    }
}
