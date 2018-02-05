using Law.Core;
using Law.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law.Admin.Models
{
    public class AffiliatesViewModel
    {
        public PaginatedList<Affiliate> FoundAffiliates { get; set; }
        public string Keyword { get; set; }

        public AffiliatesViewModel(string keyword, string page)
        {
            this.FoundAffiliates = AffiliateCore.GetFilteredAffiliates(keyword, page);
            this.Keyword = keyword;
        }
    }
}
