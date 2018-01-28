using System;
using System.Collections.Generic;
using System.Text;

namespace Law.Models
{
    public class City: NameBase
    {
        public City(string ID,string Name,string CountryID) :base(ID,Name)
        {
            this.CountryID = CountryID;
        }

        public string CountryID { get; set; }
    }
}
