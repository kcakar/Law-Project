using Law.Core;
using Law.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law.Web.Models
{
    public class ArticleSearchViewModel
    {
        public PaginatedList<Article> FoundArticles { get; set; }
        public List<Contributor> RelatedContributors { get; set; }
        public List<Affiliate> RelatedAffiliates { get; set; }
        public FilterModel FilterModel { get; set; }
        public ArticleSearchViewModel(FilterModel FilterModel, string affiliate, string practice, string contributor, string country, string city, string page)
        {
            this.FilterModel = FilterModel;
            if(!string.IsNullOrWhiteSpace(country))
            {
                this.FilterModel.Cities = Common.GetCitiesByCountry(country);
            }

            if (!string.IsNullOrWhiteSpace(contributor))
            {
                this.FilterModel.Contributors = Common.GetContributors();
            }

            FilterModel.selectedCity = city;
            FilterModel.selectedContributor = contributor;
            FilterModel.selectedPractice = practice;
            FilterModel.selectedCountry = country;
            FilterModel.selectedAffiliate = affiliate;

            this.FoundArticles = ArticleCore.GetFilteredArticles(affiliate, practice, contributor, country, city, page);
            this.RelatedContributors = ContributorCore.GetContributorsById(FoundArticles.Select(x => x.ContributorID).ToList());
            this.RelatedAffiliates = AffiliateCore.GetAffiliatesById(FoundArticles.Select(x => x.AffiliateID).ToList());
        }
    }
}
