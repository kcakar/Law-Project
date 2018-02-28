using Law.Test;
using System.Linq;

namespace Law.Core
{
    public class AuthenticationCore : CoreBase
    {
        public static bool CheckAuth(string username, string password)
        {
            if (Tester.TestUsers.Any(x => x.Email == username && x.Password == password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
