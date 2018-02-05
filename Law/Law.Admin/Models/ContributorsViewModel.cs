using Law.Core;
using Law.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law.Admin.Models
{
    public class ContributorsViewModel
    {
        public PaginatedList<Contributor> FoundContributors { get; set; }
        public List<Affiliate> RelatedAffiliates { get; set; }
        public List<City> Cities { get; set; }
        public List<Country> Countries { get; set; }
        public string keyword { get; set; }


        public ContributorsViewModel(string keyword, string affiliate, string contributor, string country, string city, string page, List<City> cities, List<Country> countries)
        {
            this.FoundContributors = ContributorCore.GetFilteredContributors(keyword, affiliate, contributor, country, city, page);
            this.RelatedAffiliates = AffiliateCore.GetAffiliatesById(FoundContributors.Select(x => x.AffiliateID).ToList());
            this.Cities = cities;
            this.Countries = countries;
            this.keyword = keyword;
        }
    }
}
