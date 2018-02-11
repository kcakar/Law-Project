using Law.Core;
using Law.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Law.Admin.Models
{
    public class UsersViewModel
    {
        public PaginatedList<User> FoundUsers { get; set; }
        public string Keyword { get; set; }

        public UsersViewModel(string keyword, string page)
        {
            this.FoundUsers = UserCore.GetFilteredUsers(keyword, page);
            this.Keyword = keyword;
        }
    }
}
