using Law.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Law.Core;
using System.Linq;

namespace Law.Web.Models
{
    public class IndexViewModel
    {
        public List<Article> PopularArticles { get; set; }
        public List<Article> RecentArticles { get; set; }
        public List<Contributor> RecentContributors { get; set; }
        public List<Affiliate> Affiliates { get; set; }
        public FilterModel FilterModel { get; set; }
        public IndexViewModel(FilterModel FilterModel)
        {
            this.FilterModel = FilterModel;

            Article article = new Article();
            //ArticleCore.GetMostPopularArticles()
            PopularArticles = ArticleCore.GetMostPopularArticles(5);
            RecentArticles = ArticleCore.GetMostRecentArticles(12);
            RecentContributors = ContributorCore.GetMostRecentContributors(10);

            List<string> ContributorIds = RecentArticles.Select(x => x.ContributorID).ToList();
            ContributorIds.AddRange(PopularArticles.Select(x => x.ContributorID).ToList());
            //Recent Articles'teki referans edilmiş adamları da ekliyorum
            RecentContributors.AddRange(ContributorCore.GetContributorsById(ContributorIds));

            //Referans edilmiş şiretleri ekliyorum
            Affiliates=AffiliateCore.GetAffiliatesById(RecentContributors.Select(x => x.AffiliateID).ToList());
        }
    }
}
