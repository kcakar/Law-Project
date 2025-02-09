﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Law.Admin.Models;
using Law.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Law.Core;
using Law.Test;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System.Text;

namespace Law.Admin.Controllers
{
    public class HomeController : CommonController
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeController(IHostingEnvironment hostingEnvironment, IMemoryCache memoryCache) : base(memoryCache)
        {
            _hostingEnvironment = hostingEnvironment;
            Tester.GenerateTestData();
        }

        public IActionResult Index()
        {

            IndexViewModel model = new IndexViewModel()
            {
                TotalAffiliates = AffiliateCore.GetAffiliateCount().ToString(),
                TotalArticles = ArticleCore.GetArticleCount().ToString(),
                TotalContributors = ContributorCore.GetContributorCount().ToString(),
                TotalViews = ArticleCore.GetArticleCount().ToString(),
                MostReadArticles = ArticleCore.GetMostReadArticles(5),
                MostReadContributors = ContributorCore.GetMostReadContributors(5),
                MostWrittenContributors = ContributorCore.GetMostWrittenContributors(5)
            };

            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<JsonResult> UploadImage(IFormFile file)
        {
            try
            {
                var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                string imageURL = "~/uploads/" + imageName;
                if (file.Length > 0)
                {
                    using (var fileStream = new FileStream(Path.Combine(uploads, imageName), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                }
                return Json(new { success = true, url = imageURL, message = "Resim yüklendi" });

            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                return Json(new { success = false, error = "Resim yüklenemedi", tech = ex.Message });
            }


        }

        public IActionResult GetTestJson()
        {
            var contentType = "text/xml";
            var content=System.Web.HttpUtility.UrlEncode(Tester.GetTestJson());
            //var content = Uri.EscapeDataString(Tester.GetTestJson());
            var bytes = Encoding.UTF8.GetBytes(content);
            var result = new FileContentResult(bytes, contentType)
            {
                FileDownloadName = "myfile.txt"
            };
            return result;
        }




        public IActionResult Articles(string keyword = "", string practice = "", string contributor = "", string country = "", string city = "", string page = "1")
        {

            return View(new ArticlesViewModel(keyword, practice, contributor, country, city, page, CacheItems.Cities, CacheItems.Countries));
        }

        public IActionResult AddArticle(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                Article article = ArticleCore.GetArticleByArticleId(id);
                if (article != null)
                {
                    Contributor contributor = ContributorCore.GetContributorsById(article.ContributorID);
                    PracticeArea practiceArea = PracticeAreaCore.GetPracticeAreasById(article.PracticeAreaID);
                    List<ArticlePiece> pieces = ArticleCore.GetArticlePiecesByArticleId(article.ID);
                    return View(new ArticleAddEditModel(article, pieces, contributor, practiceArea));
                }
            }
            return View(new ArticleAddEditModel());
        }

        [HttpPost]
        public IActionResult AddArticlePost(ArticleAddEditModel model)
        {
            Result result = new Result("Makale kaydedildi", true, "");
            try
            {
                ArticleCore.AddEditArticle(model);
            }
            catch (Exception ex)
            {
                result = new Result("Makale kaydedilirken bir hata oluştu", false, ex.Message);
            }
            return Json(result);
        }

        [HttpPost]
        public IActionResult RemoveArticlePiece(string id)
        {
            Result result = new Result("Parça silindi", true, "");
            try
            {
                ArticleCore.RemoveArticlePiece(id);
            }
            catch (Exception ex)
            {
                result = new Result("Parça silinirken bir hata oluştu", false, ex.Message);
            }
            return Json(result);
        }

        public IActionResult RemoveArticle(string id, string page = "1")
        {
            Result result = new Result("Makale silindi", true, "");
            try
            {
                ArticleCore.RemoveArticle(id);
            }
            catch (Exception ex)
            {
                result = new Result("Makale silinirken bir hata oluştu", false, ex.Message);
            }
            return RedirectToAction("Articles", new { id = id, page = page });
        }




        public IActionResult Contributors(string keyword = "", string affiliate = "", string contributor = "", string country = "", string city = "", string page = "1")
        {

            return View(new ContributorsViewModel(keyword, affiliate, contributor, country, city, page, CacheItems.Cities, CacheItems.Countries));
        }

        public IActionResult AddContributor(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                Contributor contributor = ContributorCore.GetContributorsById(id);
                if (contributor != null)
                {
                    Affiliate affiliate = AffiliateCore.GetAffiliatesById(contributor.AffiliateID);
                    return View(new ContributorAddEditModel(contributor,CacheItems.Countries,CacheItems.Cities, affiliate));
                }
            }
            return View(new ContributorAddEditModel());
        }

        [HttpPost]
        public IActionResult AddContributorPost(ContributorAddEditModel model)
        {
            Result result = new Result("Yazar kaydedildi", true, "");
            try
            {
                ContributorCore.AddEditContributor(model);
            }
            catch (Exception ex)
            {
                result = new Result("Yazar kaydedilirken bir hata oluştu", false, ex.Message);
            }
            return Json(result);
        }

        public IActionResult RemoveContributor(string id, string page = "1")
        {
            Result result = new Result("Yazar silindi", true, "");
            try
            {
                ContributorCore.RemoveContributor(id);
            }
            catch (Exception ex)
            {
                result = new Result("Yazar silinirken bir hata oluştu", false, ex.Message);
            }
            return RedirectToAction("Contributors", new { id = id, page = page });
        }




        public IActionResult Affiliates(string keyword = "", string affiliate = "", string contributor = "", string country = "", string city = "", string page = "1")
        {
            return View(new AffiliatesViewModel(keyword, page));
        }

        public IActionResult AddAffiliate(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                Affiliate affiliate = AffiliateCore.GetAffiliatesById(id);
                if (affiliate != null)
                {
                    return View(new AffiliateAddEditModel(affiliate));
                }
            }
            return View(new AffiliateAddEditModel());
        }

        [HttpPost]
        public IActionResult AddAffiliatePost(AffiliateAddEditModel model)
        {
            Result result = new Result("Şirket kaydedildi", true, "");
            try
            {
                AffiliateCore.AddEditAffiliate(model);
            }
            catch (Exception ex)
            {
                result = new Result("Şirket kaydedilirken bir hata oluştu", false, ex.Message);
            }
            return Json(result);
        }

        public IActionResult RemoveAffiliate(string id, string page = "1")
        {
            Result result = new Result("Şirket silindi", true, "");
            try
            {
                AffiliateCore.RemoveAffiliate(id);
            }
            catch (Exception ex)
            {
                result = new Result("Şirket silinirken bir hata oluştu", false, ex.Message);
            }
            return RedirectToAction("Affiliates", new { id = id, page = page });
        }




        public IActionResult PracticeAreas(string keyword = "", string page = "1")
        {

            return View(new PracticeAreasViewModel(keyword, page));
        }

        public IActionResult AddPracticeArea(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                PracticeArea practiceArea = PracticeAreaCore.GetPracticeAreasById(id);
                if (practiceArea != null)
                {
                    return View(new PracticeAreaAddEditModel(practiceArea));
                }
            }
            return View(new PracticeAreaAddEditModel());
        }

        [HttpPost]
        public IActionResult AddPracticeAreaPost(PracticeAreaAddEditModel model)
        {
            Result result = new Result("Disiplin kaydedildi", true, "");
            try
            {
                PracticeAreaCore.AddEditPracticeArea(model);
            }
            catch (Exception ex)
            {
                result = new Result("Disiplin kaydedilirken bir hata oluştu", false, ex.Message);
            }
            return Json(result);
        }

        public IActionResult RemovePracticeArea(string id, string page = "1")
        {
            Result result = new Result("Disiplin silindi", true, "");
            try
            {
                PracticeAreaCore.RemovePracticeArea(id);
            }
            catch (Exception ex)
            {
                result = new Result("Disiplin silinirken bir hata oluştu", false, ex.Message);
            }
            return RedirectToAction("PracticeAreas", new { id = id, page = page });
        }





        public IActionResult Users(string keyword = "", string page = "1")
        {
            return View(new UsersViewModel(keyword, page));
        }

        public IActionResult AddUser(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                User user = UserCore.GetUsersById(id);
                if (user != null)
                {
                    return View(new UserAddEditModel(user));
                }
            }
            return View(new UserAddEditModel());
        }

        [HttpPost]
        public IActionResult AddUserPost(PracticeAreaAddEditModel model)
        {
            Result result = new Result("Kullanıcı kaydedildi", true, "");
            try
            {
                PracticeAreaCore.AddEditPracticeArea(model);
            }
            catch (Exception ex)
            {
                result = new Result("Kullanıcı kaydedilirken bir hata oluştu", false, ex.Message);
            }
            return Json(result);
        }

        public IActionResult RemoveUser(string id, string page = "1")
        {
            Result result = new Result("Kullanıcı silindi", true, "");
            try
            {
                UserCore.RemoveUsers(id);
            }
            catch (Exception ex)
            {
                result = new Result("Kullanıcı silinirken bir hata oluştu", false, ex.Message);
            }
            return RedirectToAction("Users", new { id = id, page = page });
        }

    }
}
