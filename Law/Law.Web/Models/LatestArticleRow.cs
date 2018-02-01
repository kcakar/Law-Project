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

            if(span.Days>0)
            {
                return String.Format("{0} days, {1} hours", span.Days, span.Hours);
            }
            else if(span.Hours>0)
            {
                return String.Format("{0} hours, {1} minutes", span.Hours, span.Minutes);
            }
            else if (span.Minutes > 0)
            {
                return String.Format("{0} minutes, {1} seconds", span.Minutes, span.Seconds);
            }
            else
            {
                return String.Format("{0} seconds", span.Seconds);
            }
        }
    }
}
