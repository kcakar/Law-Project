using Law.Models;
using Law.Test;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Law.Core
{

    public static class AffiliateCore
    {
        public static int GetAffiliateCount()
        {
            return Tester.TestAffiliates.Count;
        }

        public static List<Affiliate> GetAffiliatesById(List<string> ids)
        {
            return Tester.TestAffiliates.Where(x => ids.Contains(x.ID)).ToList();
        }

        public static Affiliate GetAffiliatesById(string id)
        {
            if(id==null)
            {
                return new Affiliate();
            }
            return Tester.TestAffiliates.FirstOrDefault(x => x.ID == id);
        }

        public static List<Affiliate> GetAffiliatesByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "";
            }
            return Tester.TestAffiliates.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
        }

        public static List<Affiliate> GetMostRecentAffiliates(int amount)
        {
            return Tester.TestAffiliates.OrderByDescending(x => x.CreationDate).Take(amount).ToList();
        }


        public static PaginatedList<Affiliate> GetFilteredAffiliates(string keyword, string page = "1")
        {
            var qry = Tester.TestAffiliates.OrderByDescending(x => x.CreationDate).AsQueryable();

            if (!int.TryParse(page, out int pageNumber))
            {
                pageNumber = 1;
            }

            return PaginatedList<Affiliate>.Create(qry, pageNumber, Common.PageSize);
        }

        public static void AddEditAffiliate(AffiliateAddEditModel model)
        {
            Affiliate affiliate = new Affiliate
            {
                Name = model.Name.CapitaliseFirstLetters(),
                CreationDate = model.CreationDate,
                ID = model.ID,
                Description=model.Description
            };

            if (model.ImageURL == null)
            {
                model.ImageURL = "";
            }
            affiliate.ImageURL = model.ImageURL.Replace("~", "");
            //ID mevcutsa güncelle, yoksa ekle
            if (!Tester.TestAffiliates.Exists(x => x.ID != affiliate.ID))
            {
                Tester.TestAffiliates.Add(affiliate);
            }
            else
            {
                //dbde update normalde
                Tester.TestAffiliates.RemoveAll(x => x.ID == model.ID);
                Tester.TestAffiliates.Add(affiliate);
            }
        }

        public static int RemoveAffiliate(string id)
        {
            return Tester.TestAffiliates.RemoveAll(x => x.ID == id);
        }
    }
}
