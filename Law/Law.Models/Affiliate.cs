using System;
using System.Collections.Generic;
using System.Text;

namespace Law.Models
{
    public class Affiliate:NameBase
    {
        public string ImageURL { get; set; }
        public string Description { get; set; }

        public Affiliate():base(Guid.NewGuid().ToString(),"")
        {
            
        }
        public Affiliate(string ID,string Name):base(ID,Name)
        {

        }

    }
}
