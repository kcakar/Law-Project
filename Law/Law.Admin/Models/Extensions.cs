using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law.Admin.Models
{
    public static class Extensions
    {
        public static string siteName = "http://lawwebkcakar.azurewebsites.net";
        public static string GetWebArticleUrl(this string URL)
        {
            return siteName + "/Articles/Article/" + URL;
        }
        public static string GetWebContributorUrl(this string URL)
        {
            return siteName+"/Contributors/Contributor/" + URL;
        }
    }
}
