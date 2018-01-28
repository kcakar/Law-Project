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

        public FilterModel(List<Country> Countries, List<City> Cities,List<PracticeArea> Practices)
        {
            this.Cities = Cities;
            this.Countries = Countries;
            this.Practices = Practices;
        }
    }
}
