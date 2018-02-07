using Law.Models;
using Law.Test;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Law.Core
{
    public class PracticeAreaCore
    {

        public static List<PracticeArea> GetPracticeAreasById(List<string> ids)
        {
            return Tester.TestPracticeAreas.Where(x => ids.Contains(x.ID)).ToList();
        }

        public static PracticeArea GetPracticeAreasById(string id)
        {
            return Tester.TestPracticeAreas.FirstOrDefault(x => x.ID == id);
        }

        public static List<PracticeArea> GetPracticeAreasByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                name = "";
            }
            return Tester.TestPracticeAreas.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
        }

        public static PaginatedList<PracticeArea> GetFilteredPracticeAreas(string keyword,string page = "1")
        {
            var qry = Tester.TestPracticeAreas.OrderByDescending(x => x.CreationDate).AsQueryable();

            if (!int.TryParse(page, out int pageNumber))
            {
                pageNumber = 1;
            }

            return PaginatedList<PracticeArea>.Create(qry, pageNumber, Common.PageSize);
        }

        public static void AddEditPracticeArea(PracticeAreaAddEditModel model)
        {
            PracticeArea area = new PracticeArea
            {
                Name = model.Name.CapitaliseFirstLetters(),
                CreationDate = model.CreationDate,
                ID = model.ID
            };

            //ID mevcutsa güncelle, yoksa ekle
            if (!Tester.TestPracticeAreas.Exists(x => x.ID != area.ID))
            {
                Tester.TestPracticeAreas.Add(area);
            }
            else
            {
                //dbde update normalde
                Tester.TestPracticeAreas.RemoveAll(x => x.ID == model.ID);
                Tester.TestPracticeAreas.Add(area);
            }
        }

        public static int RemovePracticeArea(string id)
        {
            return Tester.TestPracticeAreas.RemoveAll(x => x.ID == id);
        }
    }
}
