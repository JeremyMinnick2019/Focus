using FocusBackend.Data;
using FocusBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FocusBackend.Repositories
{
    public class CategoryRepository : Repository<Category>, IRepository<Category>
    {
        private DbContext db;
        public CategoryRepository(FocusContext context) : base(context)
        {
            this.db = context;
        }
        public override Category GetById(int id)
        {
            return db.Set<Category>().Where(i => i.ID == id).Include("Activities").FirstOrDefault();
        }
    }
}
