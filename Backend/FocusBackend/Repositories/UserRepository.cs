using FocusBackend.Data;
using FocusBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FocusBackend.Repositories
{
    public class UserRepository : Repository<User>, IRepository<User>
    {
        private DbContext db;
        public UserRepository(FocusContext context) : base(context)
        {
            this.db = context;
        }
        public override User GetById(int id)
        {
            return db.Set<User>().Where(i => i.ID == id).Include("Businesses").FirstOrDefault();
        }

    }
}
