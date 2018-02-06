using System;
using System.Collections.Generic;
using System.Text;

namespace Law.Models.AddEditModels
{
    class ContributorAddEditModel
    {
        public ContributorAddEditModel()
        {
            this.ID = Guid.NewGuid().ToString();
            this.CreationDate = DateTime.Now;
        }

        public ContributorAddEditModel(Contributor contributor)
        {
            this.ID = contributor.ID;
            this.Name = contributor.Name;
            this.CreationDate = contributor.CreationDate;
           
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
