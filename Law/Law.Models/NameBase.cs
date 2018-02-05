using System;
using System.Collections.Generic;
using System.Text;

namespace Law.Models
{
    public class NameBase
    {
        public NameBase(string ID,string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
