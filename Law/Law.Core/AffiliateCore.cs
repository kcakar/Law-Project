using Law.Models;
using Law.Test;
using System.Collections.Generic;
using System.Linq;

namespace Law.Core
{

    public static class AffiliateCore
    {
        public static int GetAffiliateCount()
        {
            return Tester.TestAffiliates.Count;
        }

        public static List<Affiliate> GetAffiliatesById(List<string> ids)
        {
            return Tester.TestAffiliates.Where(x => ids.Contains(x.ID)).ToList();
        }

        public static Affiliate GetAffiliatesById(string id)
        {
            return Tester.TestAffiliates.FirstOrDefault(x => x.ID == id);
        }

        public static PaginatedList<Affiliate> GetFilteredAffiliates(string keyword, string page = "1")
        {
            var qry = Tester.TestAffiliates.OrderByDescending(x => x.CreationDate).AsQueryable();

            if (!int.TryParse(page, out int pageNumber))
            {
                pageNumber = 1;
            }

            return PaginatedList<Affiliate>.Create(qry, pageNumber, Common.PageSize);
        }
    }
}
