using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Law.Core;
using Law.Web.Controllers;
using Law.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{

    public class ArticlesController : CommonController
    {
        public ArticlesController(IMemoryCache memoryCache) : base(memoryCache)
        {

        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(new ArticleSearchViewModel(this.FilterModel));
        }

        public IActionResult Article(string id)
        {
            return View(new ArticleViewModel(ArticleCore.GetArticleByArticleId(id)));
        }


    }
}
