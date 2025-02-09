﻿using Law.Models;
using Law.Test;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Law.Core
{
    public class Common : CoreBase
    {
        public static readonly int PageSize=20;

        public static List<Country> GetCountries()
        {
            return Tester.TestCountries;
        }

        public static List<City> GetCities()
        {
            return Tester.TestCities;
        }

        public static List<City> GetCitiesByCountry(string country)
        {
            return Tester.TestCities.Where(x=>x.CountryID==country).ToList();
        }

        public static List<Contributor> GetContributors()
        {
            return Tester.TestContributors;
        }

        public static List<PracticeArea> GetPractices()
        {
            return Tester.TestPracticeAreas;
        }

        public static List<Affiliate> GetAffiliates()
        {
            return Tester.TestAffiliates;
        }



    }

    public static class Extensions
    {
        public static string CapitaliseFirstLetters(this string source)
        {
            source = source.ToLower();

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(source);
        }

        public static List<List<T>> ChunkBy<T>(this List<T> source, int chunkSize)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunkSize)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }

    }
}
