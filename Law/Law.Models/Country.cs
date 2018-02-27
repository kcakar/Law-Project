using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Law.Models
{
    [Table("Country")]
    public class Country:NameBase
    {
        public Country() : base("", "")
        {

        }
        public Country(string ID,string Name):base(ID,Name)
        {

        }
    }
}
