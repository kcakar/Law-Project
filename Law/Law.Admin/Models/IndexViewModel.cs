using Law.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law.Admin.Models
{
    public class IndexViewModel
    {
        public string TotalContributors { get; set; }
        public string TotalArticles { get; set; }
        public string TotalAffiliates { get; set; }
        public string TotalViews { get; set; }
        public List<Contributor> MostWrittenContributors { get; set; }
        public List<Contributor> MostReadContributors { get; set; }
        public List<Article> MostReadArticles { get; set; }
    }
}
