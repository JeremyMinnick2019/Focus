using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FocusBackend.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Business> Businesses { get; set; }

        public User(int id, string name, string email, string phone, string image)
        {
            ID = id;
            Name = name;
            Email = email;
            Phone = phone;
            Image = image;
        }
        public User()
        {

        }
    }
}
