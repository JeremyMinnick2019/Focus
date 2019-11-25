using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FocusBackend.Models
{
    public class Business
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Industry { get; set; }
        public string Image { get; set; }


        public int UserID { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Category> Categories { get; set; }

        public Business(int id, string name, string industry, string image, int userID)
        {
            ID = id;
            Name = name;
            Industry = industry;
            Image = image;
            UserID = userID;
        }
        public Business()
        {

        }
    }
}
