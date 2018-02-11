using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Law.Core;
using Law.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Law.Web.Controllers
{
    public class AffiliatesController : CommonController
    {
        public AffiliatesController(IMemoryCache memoryCache) : base(memoryCache)
        {

        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(new AffiliatesViewModel(AffiliateCore.GetMostRecentAffiliates(100)));
        }


        public IActionResult Affiliate(string id)
        {
            return View(new AffiliateViewModel(id));
        }

    }
}