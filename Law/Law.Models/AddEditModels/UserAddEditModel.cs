using System;
using System.Collections.Generic;
using System.Text;

namespace Law.Models
{
    public class UserAddEditModel
    {
        public UserAddEditModel()
        {
            this.ID = Guid.NewGuid().ToString();
            this.CreationDate = DateTime.Now;
        }

        public UserAddEditModel(User user)
        {
            this.ID = user.ID;
            this.Name = user.Name;
            this.CreationDate = user.CreationDate;
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
