using Law.Core;
using Law.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law.Admin.Models
{
    public class PracticeAreasViewModel
    {
        public PaginatedList<PracticeArea> FoundPracticeAreas { get; set; }
        public string Keyword { get; set; }

        public PracticeAreasViewModel(string keyword,string page)
        {
            this.FoundPracticeAreas = PracticeAreaCore.GetFilteredPracticeAreas(keyword, page);
            this.Keyword = keyword;
        }
    }
}
