using System;
using System.Collections.Generic;
using System.Text;

namespace Law.Models
{
    public class PracticeAreaAddEditModel
    {
        public PracticeAreaAddEditModel()
        {
            this.ID = Guid.NewGuid().ToString();
            this.CreationDate = DateTime.Now;
        }

        public PracticeAreaAddEditModel(PracticeArea practiceArea)
        {
            this.ID = practiceArea.ID;
            this.Name = practiceArea.Name;
            this.CreationDate = practiceArea.CreationDate;
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
