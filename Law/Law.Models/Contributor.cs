using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Law.Models
{
    [Table("Contributor")]
    public class Contributor : NameBase
    {
        public Contributor() : base("", "")
        {

        }
        public Contributor(string ID, string Name) : base(ID, Name)
        {

        }
        public Contributor(string ID, string Name, string CountryID="", string CityID = "", string AffiliateID = "",string ImageURL = "",string Bio="") : base(ID,Name)
        {
            this.CountryID = CountryID;
            this.CityID = CityID;
            this.AffiliateID = AffiliateID;
            this.ImageURL = ImageURL;
            CreationDate = DateTime.Now;
            LastPostDate = DateTime.MinValue;
            TotalContributions = 0;
            this.Email = "";
            this.Bio = Bio;
        }

        public string Bio { get; set; }
        public string Email { get; set; }
        public string CountryID { get; set; }
        public string CityID { get; set; }
        public string AffiliateID { get; set; }
        public string ImageURL { get; set; }
        public DateTime LastPostDate { get; set; }
        public int TotalContributions { get; set; }

    }
}
