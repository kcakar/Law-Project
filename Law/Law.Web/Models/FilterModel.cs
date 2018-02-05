using Law.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law.Web.Models
{
    public class FilterModel
    {
        public List<Country> Countries { get; set; }
        public List<City> Cities { get; set; }
        public List<PracticeArea> Practices { get; set; }
        public List<Contributor> Contributors { get; set; }
        public List<Affiliate> Affiliates { get; set; }

        public string selectedCountry = "";
        public string selectedContributor = "";
        public string selectedPractice = "";
        public string selectedCity = "";
        public string selectedAffiliate = "";

        public FilterModel(List<Affiliate> Affiliates, List<Country> Countries, List<City> Cities, List<PracticeArea> Practices, string selectedCountry = "", string selectedContributor = "", string selectedPractice = "", string selectedCity = "",string selectedAffiliate="")
        {
            this.Contributors = new List<Contributor>();
            this.Affiliates = Affiliates;
            this.Cities = Cities;
            this.Countries = Countries;
            this.Practices = Practices;
            this.selectedCountry = selectedCountry;
            this.selectedContributor = selectedContributor;
            this.selectedPractice = selectedPractice;
            this.selectedCity = selectedCity;
            this.selectedAffiliate = selectedAffiliate;
        }
    }
}
