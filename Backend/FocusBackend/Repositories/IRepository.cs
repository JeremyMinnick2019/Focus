using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FocusBackend.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> GetByDone();

        IEnumerable<T> GetByNotDone();

        IEnumerable<T> GetByRank();

        int GetUserPoints();

        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
