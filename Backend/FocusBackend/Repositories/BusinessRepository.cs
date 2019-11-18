using FocusBackend.Data;
using FocusBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FocusBackend.Repositories
{
    public class BusinessRepository : Repository<Business>, IRepository<Business>
    {
        private DbContext db;
        public BusinessRepository(FocusContext context) : base(context)
        {
            this.db = context;
        }
        public override Business GetById(int id)
        {
            return db.Set<Business>().Where(i => i.ID == id).Include("Categories").FirstOrDefault();
        }
    }
}
