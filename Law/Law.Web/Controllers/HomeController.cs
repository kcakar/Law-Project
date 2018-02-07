using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Law.Test;
using Law.Models;
using Microsoft.AspNetCore.Mvc;
using Law.Web.Models;
using Microsoft.Extensions.Caching.Memory;
using Law.Web;
using Law.Web.Controllers;

namespace Web.Controllers
{
    public class HomeController : CommonController
    {

        public HomeController(IMemoryCache memoryCache):base(memoryCache)
        {
        }

        public IActionResult Index()
        {
            return View(new IndexViewModel(this.FilterModel));
        }

        public IActionResult Articles()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

       
    }
}
