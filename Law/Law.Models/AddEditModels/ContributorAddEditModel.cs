using System;
using System.Collections.Generic;
using System.Linq;

namespace Law.Models
{
    public class ContributorAddEditModel
    {
        public ContributorAddEditModel()
        {
            this.ID = Guid.NewGuid().ToString();
            this.CreationDate = DateTime.Now;
        }

        public ContributorAddEditModel(Contributor contributor,List<Country> Countries,List<City> Cities,Affiliate affiliate)
        {
            this.ID = contributor.ID;
            this.Name = contributor.Name;
            this.CreationDate = contributor.CreationDate;
            this.Bio = contributor.Bio;
            this.Email = contributor.Email;
            this.CountryID = contributor.CountryID;
            this.CityID = contributor.CityID;
            this.AffiliateID = contributor.AffiliateID;
            this.ImageURL = contributor.ImageURL;

            City city = Cities.FirstOrDefault(x => x.ID == contributor.CityID);
            if(city!=null)
            {
                this.CityName = city.Name;
            }

            Country country = Countries.FirstOrDefault(x => x.ID == contributor.CountryID);
            if (country != null)
            {
                this.CountryName = country.Name;
            }

            if (affiliate != null)
            {
                this.AffiliateName = affiliate.Name;
            }
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public string CountryID { get; set; }
        public string CountryName { get; set; }
        public string CityID { get; set; }
        public string CityName { get; set; }
        public string AffiliateID { get; set; }
        public string AffiliateName { get; set; }
        public string ImageURL { get; set; }
    }
}
