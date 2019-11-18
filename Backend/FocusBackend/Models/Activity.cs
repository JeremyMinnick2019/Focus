﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FocusBackend.Models
{
    public class Activity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Creation { get; set; }
        public DateTime Completion { get; set; }
        public int Importance { get; set; }
        public int Urgency { get; set; }
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public Activity(int id, string name, string description, DateTime creation, DateTime completion, int importance, int urgency, int categoryID)
        {
            ID = id;
            Name = name;
            Description = description;
            Creation = creation;
            Completion = completion;
            Importance = importance;
            Urgency = urgency;
            CategoryID = categoryID;
        }
        public Activity()
        {

        }
        

    }
}
