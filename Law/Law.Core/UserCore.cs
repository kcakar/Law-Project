using Law.Models;
using Law.Test;
using System.Linq;

namespace Law.Core
{
    public class UserCore
    {
        public static PaginatedList<User> GetFilteredUsers(string keyword, string page = "1")
        {
            var qry = Tester.TestUsers.OrderByDescending(x => x.CreationDate).AsQueryable();

            if (!int.TryParse(page, out int pageNumber))
            {
                pageNumber = 1;
            }

            return PaginatedList<User>.Create(qry, pageNumber, Common.PageSize);
        }

        public static User GetUsersById(string id)
        {
            return Tester.TestUsers.FirstOrDefault(x => x.ID == id);
        }

        public static void AddUser(UserAddEditModel model)
        {
            User user = new User(model.ID,model.Name)
            {
                CreationDate = model.CreationDate,
            };

            //ID mevcutsa güncelle, yoksa ekle
            if (!Tester.TestUsers.Exists(x => x.ID != user.ID))
            {
                Tester.TestUsers.Add(user);
            }
            else
            {
                //dbde update normalde
                Tester.TestUsers.RemoveAll(x => x.ID == model.ID);
                Tester.TestUsers.Add(user);
            }
        }

        public static int RemoveUsers(string id)
        {
            return Tester.TestUsers.RemoveAll(x => x.ID == id);
        }
    }
}
