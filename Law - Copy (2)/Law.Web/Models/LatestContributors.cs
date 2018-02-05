using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law.Web.Models
{
    public class LatestContributorsRow
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int TotalContributions { get; set; }
        public string ImageURL { get; set; }

        public LatestContributorsRow(string ID,string Name,int TotalContributions,string ImageURL)
        {
            this.ID = ID;
            this.Name = Name;
            this.TotalContributions = TotalContributions;
            this.ImageURL = ImageURL;
        }
    }
}
