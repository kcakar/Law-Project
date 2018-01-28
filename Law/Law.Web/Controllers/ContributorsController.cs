using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Law.Core;
using Law.Web.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    public class ContributorsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contributor(string id)
        {
            return View(new ContributorViewModel(ContributorCore.GetContributorsById(id)));
        }
    }
}
