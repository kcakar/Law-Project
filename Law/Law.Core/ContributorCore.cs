using Law.Models;
using Law.Test;
using System.Collections.Generic;
using System.Linq;

namespace Law.Core
{
    public static class ContributorCore
    {
        public static List<Contributor> GetMostRecentContributors(int amount)
        {
            return Tester.TestContributors.OrderByDescending(x => x.CreationDate).Take(amount).ToList();
        }

        public static List<Contributor> GetLatestContributors(int amount)
        {
            return Tester.TestContributors.OrderByDescending(x => x.LastPostDate).Take(amount).ToList();
        }

        public static List<Contributor> GetContributorsById(List<string> ids)
        {
            return Tester.TestContributors.Where(x=>ids.Contains(x.ID)).ToList();
        }

        public static Contributor GetContributorsById(string id)
        {
            return Tester.TestContributors.FirstOrDefault(x => x.ID==id);
        }
    }
}
