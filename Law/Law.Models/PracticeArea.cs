using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Law.Models
{
    [Table("PracticeArea")]
    public class PracticeArea: NameBase
    {
        public PracticeArea():base("","")
        {

        }
        public PracticeArea(string ID,string Name):base(ID,Name)
        {

        }
    }
}
