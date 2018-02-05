﻿using Law.Models;
using Law.Test;
using System.Collections.Generic;
using System.Linq;

namespace Law.Core
{
    public static class ContributorCore
    {
        public static int GetContributorCount()
        {
            return Tester.TestContributors.Count;
        }

        public static List<Contributor> GetMostReadContributors(int amount)
        {
            List<string> ids= Tester.TestArticles.GroupBy(x => x.ContributorID).Select(g => new { g.Key, TotalView = g.Sum(x=>x.ViewCount) }).OrderBy(g=>g.TotalView).Select(g=>g.Key).Take(5).Distinct().ToList();
            return ContributorCore.GetContributorsById(ids); 
        }

        public static List<Contributor> GetMostWrittenContributors(int amount)
        {
            List<string> ids = Tester.TestArticles.GroupBy(x => x.ContributorID).Select(g => new { g.Key, Count = g.Count() }).OrderBy(g => g.Count).Select(g => g.Key).Take(5).Distinct().ToList();
            return ContributorCore.GetContributorsById(ids);
        }

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

        public static List<Contributor> GetContributorsByName(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                name = "";
            }
            return Tester.TestContributors.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
        }

        public static PaginatedList<Contributor> GetFilteredContributors(string keyword,string affiliate, string contributor, string country, string city, string page = "1")
        {
            var qry = Tester.TestContributors.OrderByDescending(x => x.CreationDate).AsQueryable();

            if (!string.IsNullOrWhiteSpace(affiliate))
            {
                qry = qry.Where(x => x.AffiliateID == affiliate);
            }

            if (!string.IsNullOrWhiteSpace(country))
            {
                qry = qry.Where(x => x.CountryID == country);
            }

            if (!string.IsNullOrWhiteSpace(city))
            {
                qry = qry.Where(x => x.CityID == city);
            }

            if (!string.IsNullOrWhiteSpace(affiliate))
            {
                qry = qry.Where(x => x.AffiliateID == affiliate);
            }

            if (!int.TryParse(page, out int pageNumber))
            {
                pageNumber = 1;
            }

            return PaginatedList<Contributor>.Create(qry, pageNumber, Common.PageSize);
        }

    }
}
