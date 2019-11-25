using FocusBackend.Data;
using FocusBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FocusBackend.Repositories
{
    public class GameRepository : Repository<Game>, IRepository<Game>
    {
        private DbContext db;
        public GameRepository(FocusContext context) : base(context)
        {
            this.db = context;
        }
    }
}
