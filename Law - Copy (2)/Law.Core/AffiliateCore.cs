using Law.Models;
using Law.Test;
using System.Collections.Generic;
using System.Linq;

namespace Law.Core
{

    public static class AffiliateCore
    {
        public static List<Affiliate> GetAffiliatesById(List<string> ids)
        {
            return Tester.TestAffiliates.Where(x => ids.Contains(x.ID)).ToList();
        }

        public static Affiliate GetAffiliatesById(string id)
        {
            return Tester.TestAffiliates.FirstOrDefault(x => x.ID == id);
        }


    }
}
