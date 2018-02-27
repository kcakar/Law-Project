using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Law.Models
{
    public class NameBase
    {
        public NameBase(string ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }
        [StringLength(20),Required]
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
