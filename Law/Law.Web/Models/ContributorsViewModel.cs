using Law.Core;
using Law.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law.Web.Models
{
    public class ContributorsViewModel
    {
        public List<Contributor> Contributors { get; set; }
        public List<Affiliate> RelatedAffiliates { get; set; }

        public ContributorsViewModel(List<Contributor> Contributors)
        {
            this.Contributors = Contributors;
            this.RelatedAffiliates = AffiliateCore.GetAffiliatesById(Contributors.Select(x=>x.AffiliateID).ToList());
        }
    }
}
