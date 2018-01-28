using Law.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law.Web.Models
{
    public class ArticleSearchViewModel
    {
        public List<Article> FoundArticles { get; set; }
        public List<Contributor> RelatedContributors { get; set; }
        public List<Affiliate> RelatedAffiliates { get; set; }
        public FilterModel FilterModel { get; set; }
        public ArticleSearchViewModel(FilterModel FilterModel)
        {
            this.FilterModel = FilterModel;
        }
    }
}
