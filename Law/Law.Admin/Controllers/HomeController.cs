using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Law.Admin.Models;
using Law.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Law.Core;

namespace Law.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddArticle()
        {
            return View(new ArticleAddEditModel());
        }

        [HttpPost]
        public IActionResult AddArticlePost(ArticleAddEditModel model)
        {
            Result result = new Result("Makale eklendi",true,"");
            try
            {
                ArticleCore.AddEditArticle(model);
            }
            catch(Exception ex)
            {
               result = new Result("Makale eklenirken bir hata oluştu", false, ex.Message);
            }
            return View(result);
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
                string imageURL = "~/uploads/"+imageName;
                if (file.Length > 0)
                {
                    using (var fileStream = new FileStream(Path.Combine(uploads, imageName), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                }
                return Json(new { success = true,url= imageURL, message = "Resim yüklendi" });

            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                return Json(new {success=false, error = "Resim yüklenemedi",tech=ex.Message });
            }


        }
    }
}
