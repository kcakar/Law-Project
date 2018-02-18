using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Law.Core;
using Law.Models;
using Law.Web.Controllers;
using Law.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    public class ArticlesController : CommonController
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public ArticlesController(UserManager<ApplicationUser> userManager, IMemoryCache memoryCache) : base(memoryCache)
        {
            _userManager = userManager;

        }

        // GET: /<controller>/
        public IActionResult Index(string affiliate, string practice, string contributor, string country, string city, string page)
        {
            return View(new ArticleSearchViewModel(this.FilterModel, affiliate, practice, contributor, country, city, page));
        }

        public IActionResult Article(string id)
        {
            return View(new ArticleViewModel(ArticleCore.GetArticleByArticleId(id)));
        }


        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddCommentAsync(string body, string articleId)
        {
            Comment result = null;
            string message = "";
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.GetUserAsync(User);
                result = CommentCore.AddComment(body, articleId, user.FullName);
                if (result != null)
                {
                    message = "Comment is added.";
                }
                else
                {
                    message = "An error occured while adding the comment.";
                }
            }
            else
            {
                message = "You need to login to comment.";
            }

            return Json(new { success = result != null, message, model = result,date=result.CreationTime.ToLongDateString() });
        }


    }
}
