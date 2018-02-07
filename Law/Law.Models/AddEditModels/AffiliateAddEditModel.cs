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
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
