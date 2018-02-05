using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law.Web.Models
{
    public static class Extensions
    {
        public static string GetImageUrl(this string URL)
        {
            return "http://lawadminkcakar.azurewebsites.net/" + URL;
        }
    }
}
