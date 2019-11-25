using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FocusBackend.Models
{
    public class Game
    {
        public int ID { get; set; }
        public int TotalPoints { get; set; }
        public string Level { get; set; }


        public User User { get; set; }
        public int UserId { get; set; }

        public virtual ICollection<Activity> AActivities { get; set; }

        public Game(int id, int totalPoints, string level)
        {
            ID = id;
            TotalPoints = totalPoints;
            Level = level;
        }

        public Game()
        {

        }
    }

}
