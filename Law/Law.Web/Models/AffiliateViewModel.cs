using Law.Core;
using Law.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law.Web.Models
{
    public class AffiliateViewModel
    {
        public Affiliate Affiliate { get; set; }
        public List<Contributor> Contributors { get; set; }

        public AffiliateViewModel(string id)
        {
            this.Affiliate = AffiliateCore.GetAffiliatesById(id);
            if(this.Affiliate==null)
            {
                this.Affiliate = new Affiliate();
            }
            this.Contributors = ContributorCore.GetContributorsByAffiliateId(id);
        }
    }
}
