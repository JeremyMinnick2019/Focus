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
        T GetByDone(bool done);
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
