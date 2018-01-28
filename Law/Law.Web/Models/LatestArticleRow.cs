using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law.Web.Models
{
    public class LatestArticleRow
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string DateString { get; set; }

        public LatestArticleRow(string ID,string Title,DateTime CreationDate)
        {
            this.ID = ID;
            this.Title = Title;
            this.DateString = GetDateString(CreationDate);
        }

        public string GetDateString(DateTime CreationDate)
        {
            TimeSpan span = (DateTime.Now - CreationDate);
            return String.Format("{0} days, {1} hours, {2} minutes, {3} seconds", span.Days, span.Hours, span.Minutes, span.Seconds);
        }
    }
}
