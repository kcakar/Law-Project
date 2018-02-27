using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Law.Models
{
    [Table("Affiliate")]
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
