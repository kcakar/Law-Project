using System;
using System.Collections.Generic;
using System.Text;

namespace Law.Models
{
    public class User : NameBase
    {
        public string Password { get; set; }
        public string Email { get; set; }

        public int CommentCount { get; set; } = 0;

        public User(string ID, string name) : base(ID, name)
        {
            this.ID = Guid.NewGuid().ToString();
            this.Name = name;
            this.CreationDate = DateTime.Now;
        }
    }
}
