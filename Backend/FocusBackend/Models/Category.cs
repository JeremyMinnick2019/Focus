using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FocusBackend.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int BusinessID { get; set; }
        public virtual Business Business { get; set; }
        public virtual ICollection<Activity> Activities {get; set;}

        public Category(int id, string name, string description, int businessID)
        {
            ID = id;
            Name = name;
            Description = description;
            BusinessID = businessID;
        }
        public Category()
        {

        }

    }
}
