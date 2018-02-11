using Law.Models;
using System.Collections.Generic;

namespace Law.Web.Models
{
    public class AffiliatesViewModel
    {
        public List<Affiliate> Affiliates { get; set; }

        public AffiliatesViewModel(List<Affiliate> Affiliates)
        {
            this.Affiliates = Affiliates;
        }
    }
}
