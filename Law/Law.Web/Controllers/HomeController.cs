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
using Law.Core;

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

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckLogin(string username,string password)
        {
            bool result = AuthenticationCore.CheckAuth(username, password);
            if (result)
            {
            }

            return Json(new {message="Başarılı",success= result });
        }
    }
}
