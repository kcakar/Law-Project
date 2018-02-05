using Law.Core;
using Law.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law.Admin.Models
{
    public class ArticlesViewModel
    {
        public PaginatedList<Article> FoundArticles { get; set; }
        public List<Contributor> RelatedContributors { get; set; }
        public List<PracticeArea> RelatedAreas { get; set; }
        public List<City> Cities { get; set; }
        public List<Country> Countries { get; set; }
        public string keyword { get; set; }


        public ArticlesViewModel( string keyword, string practice, string contributor, string country, string city, string page,List<City> cities,List<Country> countries)
        {
            this.FoundArticles = ArticleCore.GetFilteredArticles(keyword, practice, contributor, country, city, page);
            this.RelatedContributors = ContributorCore.GetContributorsById(FoundArticles.Select(x => x.ContributorID).ToList());
            this.RelatedAreas =  PracticeAreaCore.GetPracticeAreasById(FoundArticles.Select(x => x.PracticeAreaID).ToList());
            this.Cities = cities;
            this.Countries = countries;
            this.keyword = keyword;
        }
    }
}
