using Law.Core;
using Law.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law.Web.Models
{
    public class ContributorViewModel
    {
        public string ContributorBio { get; set; }
        public string ContributorName { get; set; }
        public string ContributorImageURL { get; set; }
        public string Affiliate { get; set; }
        public string Education { get; set; }
        public string Language { get; set; }
        public List<ContributorArticleRow> ContributorArticles { get; set; }
        public int TotalContributions { get; set; }

        public ContributorViewModel(Contributor contributor)
        {
            this.ContributorBio = contributor.Bio;
            this.ContributorName = contributor.Name;
            this.Affiliate = AffiliateCore.GetAffiliatesById(contributor.AffiliateID).Name;
            this.Education = contributor.Education;
            this.Language = contributor.Language;
            this.ContributorImageURL = contributor.ImageURL;

            this.ContributorArticles = new List<ContributorArticleRow>();
            foreach (Article contributorArticle in ArticleCore.GetArticleByContributorId(contributor.ID, 5, 0))
            {
                ContributorArticles.Add(new ContributorArticleRow(contributorArticle));
            }

            this.TotalContributions = contributor.TotalContributions;
        }

    }
}
