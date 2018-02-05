using Law.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law.Admin
{
    public class CacheItems
    {
        public List<Country> Countries { get; set; }
        public List<City> Cities { get; set; }
        public List<PracticeArea> Practices { get; set; }
        public List<Contributor> Contributors { get; set; }

        public CacheItems(List<Country> Countries, List<City> Cities, List<PracticeArea> Practices)
        {
            this.Contributors = new List<Contributor>();
            this.Cities = Cities;
            this.Countries = Countries;
            this.Practices = Practices;
        }
    }
}
