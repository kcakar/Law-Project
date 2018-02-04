using System;
using System.Collections.Generic;
using System.Text;

namespace Law.Models
{
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
