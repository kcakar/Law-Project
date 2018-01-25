using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Law.Test;
using Law.Models;
using Microsoft.AspNetCore.Mvc;
using Law.Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Tester.GenerateTestData();
            return View(new IndexViewModel());
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
