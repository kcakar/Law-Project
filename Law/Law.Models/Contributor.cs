using System;
using System.Collections.Generic;
using System.Text;

namespace Law.Models
{
    public class Contributor : NameBase
    {
        public Contributor(string ID, string Name, string CountryID="", string CityID = "", string AffiliateID = "",string ImageURL = "") : base(ID,Name)
        {
            this.CountryID = CountryID;
            this.CityID = CityID;
            this.AffiliateID = AffiliateID;
            this.ImageURL = ImageURL;
            this.CreationDate = DateTime.Now;
        }

        public string CountryID { get; set; }
        public string CityID { get; set; }
        public string AffiliateID { get; set; }
        public string ImageURL { get; set; }
        public DateTime CreationDate{get;set;}
    }
}
