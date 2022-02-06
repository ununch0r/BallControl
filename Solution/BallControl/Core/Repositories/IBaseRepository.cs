using System.Collections.Generic;

namespace Core.Repositories
{
    public interface IBaseRepository<T>
    {
        T GetById();
        IList<T> GetAll();
        void Add(T entity);
    }
}
