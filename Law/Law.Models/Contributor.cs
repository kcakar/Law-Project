using System;
using System.Collections.Generic;
using System.Text;

namespace Law.Models
{
    public class Contributor: NameBase
    {
        public Contributor(string ID, string Name,string CountryID,string CityID,string AffiliateID):base(Name,ID)
        {
            this.CountryID = CountryID;
            this.CityID = CityID;
            this.AffiliateID = AffiliateID;
        }

        public string CountryID { get; set; }
        public string CityID { get; set; }
        public string AffiliateID { get; set; }
    }
}
