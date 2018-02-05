using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law.Admin.Models
{
    public static class Extensions
    {
        public static string GetWebArticleUrl(this string URL)
        {
            return "http://localhost:3691/Articles/Article/" + URL;
        }

    }
}
