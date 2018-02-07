using System;
using System.Collections.Generic;
using System.Text;

namespace Law.Models
{
    public class ContributorAddEditModel
    {
        public ContributorAddEditModel()
        {
            this.ID = Guid.NewGuid().ToString();
            this.CreationDate = DateTime.Now;
            this.TotalContributions = 0;
            this.LastPostDate = DateTime.MinValue;
        }

        public ContributorAddEditModel(Contributor contributor)
        {
            this.ID = contributor.ID;
            this.Name = contributor.Name;
            this.CreationDate = contributor.CreationDate;
            this.Bio = contributor.Bio;
            this.Education = contributor.Education;
            this.Language = contributor.Language;
            this.CountryID = contributor.CountryID;
            this.CityID = contributor.CityID;
            this.AffiliateID = contributor.AffiliateID;
            this.ImageURL = contributor.ImageURL;
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public string Bio { get; set; }

        public string Education { get; set; }
        public string Language { get; set; }
        public string CountryID { get; set; }
        public string CityID { get; set; }
        public string AffiliateID { get; set; }
        public string ImageURL { get; set; }
        public DateTime LastPostDate { get; set; }
        public int TotalContributions { get; set; }


    }
}
