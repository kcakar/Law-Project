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

        public static Article GetArticleByArticleId(string id)
        {
            return Tester.TestArticles.FirstOrDefault(x => x.ID == id);
        }

        public static List<Article> GetArticleByContributorId(string id, int amount, int skip)
        {
            return Tester.TestArticles.Where(x => x.ContributorID == id).Skip(skip).Take(amount).ToList();
        }

        public static PaginatedList<Article> GetFilteredArticles(string keyword, string practice, string contributor, string country, string city, string page = "1")
        {
            var qry = Tester.TestArticles.AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                qry = qry.Where(x => x.Title.ToLower().Contains(keyword.ToLower()) || x.Tags.ToLower().Contains(keyword.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(contributor))
            {
                qry = qry.Where(x => x.ContributorID == contributor);
            }

            if (!string.IsNullOrWhiteSpace(country))
            {
                qry = qry.Where(x => x.CountryID == country);
            }

            if (!string.IsNullOrWhiteSpace(city))
            {
                qry = qry.Where(x => x.CityID == city);
            }

            if (!string.IsNullOrWhiteSpace(practice))
            {
                qry = qry.Where(x => x.PracticeAreaID == practice);
            }

            int pageNumber = 1;
            if (!int.TryParse(page, out pageNumber))
            {
                pageNumber = 1;
            }

            return PaginatedList<Article>.Create(qry,pageNumber,Common.PageSize);
        }
    }
}
