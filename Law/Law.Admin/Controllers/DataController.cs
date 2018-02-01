using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Law.Core;
using Law.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Law.Admin.Controllers
{
    public class DataController : CommonController
    {
        public DataController(IMemoryCache memoryCache) : base(memoryCache)
        {

        }

        public IActionResult Contributors(string q = "")
        {
            List<SelectRow> options = new List<SelectRow>();
            foreach (Contributor contributor in ContributorCore.GetContributorsByName(q))
            {
                options.Add(new SelectRow(contributor.ID, contributor.Name));

            }
            return Json(new { results = options });
        }

        public IActionResult PracticeAreas(string q = "")
        {
            List<SelectRow> options = new List<SelectRow>();
            foreach (PracticeArea area in PracticeAreaCore.GetPracticeAreasByName(q))
            {
                options.Add(new SelectRow(area.ID, area.Name));

            }
            return Json(new { results = options });
        }

        public IActionResult Cities(string search = "", string country = "")
        {
            List<SelectRow> options = new List<SelectRow>();

            if (string.IsNullOrEmpty(country))
            {
                country = "";
            }

            foreach (City city in CacheItems.Cities.Where(x => x.CountryID == country && x.Name.ToLower().Contains(search.ToLower())))
            {
                options.Add(new SelectRow(city.ID, city.Name));
            }

            return Json(new { results = options });
        }
    }

    public class SelectRow
    {
        public SelectRow(string id, string text)
        {
            this.ID = id;
            this.Text = text;
        }
        public string ID { get; set; }
        public string Text { get; set; }
    }
}