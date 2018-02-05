using Law.Models;
using Law.Test;
using System;
using System.Collections.Generic;
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
    }
}
