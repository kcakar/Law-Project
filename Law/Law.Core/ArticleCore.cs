using Law.Models;
using Law.Test;
using System.Collections.Generic;
using System.Linq;

namespace Law.Core
{
    public static class ArticleCore
    {
        public static List<Article> GetMostRecentArticles(int amount)
        {
            return Tester.TestArticles.OrderByDescending(x => x.CreationDate).Take(amount).ToList();
        }

        public static List<Article> GetMostPopularArticles(int amount)
        {
            return Tester.TestArticles.OrderByDescending(x => x.ViewCount).Take(amount).ToList();
        }
    }
}
