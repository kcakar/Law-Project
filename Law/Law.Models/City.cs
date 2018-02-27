using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Law.Models
{
    [Table("City")]
    public class City: NameBase
    {
        public City() : base("", "") { }
        public City(string ID,string Name,string CountryID) :base(ID,Name)
        {
            this.CountryID = CountryID;
        }

        public string CountryID { get; set; }
    }
}
