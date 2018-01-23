using System;
using System.Collections.Generic;
using System.Text;

namespace Law.Models
{
    public class Contributor: NameBase
    {
        public string Title { get; set; }
        public string CountryID { get; set; }
        public string CityID { get; set; }
        public string AffiliateID { get; set; }
    }
}
