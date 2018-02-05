using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Law.Web.Controllers
{

    public class InformationController : CommonController
    {

        public InformationController(IMemoryCache memoryCache) : base(memoryCache)
        {
        }


        public IActionResult UserAgreementAndDisclaimer()
        {
            return View();
        }

        public IActionResult EditorialGuidelines()
        {
            return View();
        }

        public IActionResult EditorialPolicy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
