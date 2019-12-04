using FocusBackend.Data;
using FocusBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FocusBackend.Repositories
{
    public class ActivityRepository : Repository<Activity>, IRepository<Activity>
    {
        private DbContext db;

        public ActivityRepository(FocusContext context) : base(context)
        {
            this.db = context;

        }

        public override IEnumerable<Activity> GetAll()
        {
            var activities = db.Set<Activity>().Where(p => p.ID >= 0);
            return activities.OrderBy(activity => activity.ID);
        }
        public IEnumerable<Activity> GetByCategoryID(int categoryID)
        {
            var activities = db.Set<Activity>().Where(p => p.CategoryID == categoryID);

            return activities;
        }


        public override IEnumerable<Activity> GetByDone()
        {
            return db.Set<Activity>().Where(d => d.Done == true).Include("Category");
        }


        public override IEnumerable<Activity> GetByNotDone()
        {
            return db.Set<Activity>().Where(d => d.Done == false).Include("Category");
        }

        public override IEnumerable<Activity> GetByRank()
        {
            var activities = db.Set<Activity>().Where(d => d.Done == false);
            return activities.OrderByDescending(activity => activity.Rank).Take(3);
        }

        public override int GetUserPoints()
        {
            var completed = db.Set<Activity>().Where(d => d.Done == true);
            int total = completed.Sum(r => r.Rank);
            return total;
        }

        public override int GetAvailablePoints()
        {
            var completed = db.Set<Activity>().Where(d =>d.Done == false);
            int total = completed.Sum(r => r.Rank);
            return total;
        }
    }
}
