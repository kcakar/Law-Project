using System;

namespace Law.Models
{
    public class Article
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string ContributorID { get; set; }
        public string LanguageID { get; set; }
        public string CountryID { get; set; }
        public string CityID { get; set; }
        public string AffiliateID { get; set; }
        public string PracticeAreaID { get; set; }
        public string Tags { get; set; }
        public DateTime CreationDate { get; set; }
        public int ViewCount { get; set; }
    }
}
