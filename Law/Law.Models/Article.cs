using System;

namespace Law.Models
{
    public class Article
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string BodyPreview { get; set; }
        public string ContributorID { get; set; }
        public string LanguageID { get; set; }
        public string CountryID { get; set; }
        public string CityID { get; set; }
        public string AffiliateID { get; set; }
        public string PracticeAreaID { get; set; }
        public string Tags { get; set; }
        public DateTime CreationDate { get; set; }
        public int ViewCount { get; set; }

        public Article()
        {

        }

        public Article(string ID,string Title,string ContributorID,string LanguageID,string CountryID,string CityID,string AffiliateID,string PracticeAreaID,string BodyPreview,string Tags="")
        {
            this.ID = ID;
            this.Title = Title;
            this.ContributorID = ContributorID;
            this.LanguageID = LanguageID;
            this.CountryID = CountryID;
            this.CityID = CityID;
            this.AffiliateID = AffiliateID;
            this.PracticeAreaID = PracticeAreaID;
            this.Tags = Tags;
            CreationDate = DateTime.Now;
            this.ViewCount = 0;
            this.BodyPreview = BodyPreview;
        }
    }
}
