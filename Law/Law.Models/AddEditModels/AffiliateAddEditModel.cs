using System;
using System.Collections.Generic;
using System.Text;

namespace Law.Models
{
    public class AffiliateAddEditModel
    {
        public AffiliateAddEditModel()
        {
            this.ID = Guid.NewGuid().ToString();
            this.CreationDate = DateTime.Now;
        }

        public AffiliateAddEditModel(Affiliate affiliate)
        {
            this.ID = affiliate.ID;
            this.Name = affiliate.Name;
            this.CreationDate = affiliate.CreationDate;
            this.ImageURL = affiliate.ImageURL;
            this.Description = affiliate.Description;
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public DateTime CreationDate { get; set; }
        public string Description { get; set; }
    }
}
