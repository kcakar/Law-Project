using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Law.Core;
using Law.Models;
using Law.Test;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Law.Web.Controllers
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
            return Json(new { results = options});
        }

        public IActionResult Cities(string q = "",string country="")
        {
            List<SelectRow> options = new List<SelectRow>();

            if(string.IsNullOrEmpty(country))
            {
                country = "";
            }

            foreach (City city in FilterModel.Cities.Where(x=>x.CountryID== country&&x.Name.ToLower().Contains(q.ToLower())))
            {
                options.Add(new SelectRow(city.ID, city.Name));
            }

            return Json(new { results = options });
        }
    }

    public class SelectRow
    {
        public SelectRow(string id,string text)
        {
            this.id = id;
            this.text = text;
        }
        public string id { get; set; }
        public string text { get; set; }
    }
}