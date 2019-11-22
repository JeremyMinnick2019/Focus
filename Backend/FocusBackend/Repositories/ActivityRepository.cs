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

        //public IEnumerable<Activity> GetByCategoryID(int categoryID)
        //{
        //    var activities = db.Activities.Where(p => p.CategoryID == categoryID);

        //    return activities;
        //}


        public  override IEnumerable<Activity> GetByDone()
        {
            return db.Set<Activity>().Where(d => d.Done == true).Include("Category");
        }
    }
}
