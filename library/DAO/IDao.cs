using System.Collections.Generic;

namespace library.DAO
{
    public interface IDao<T>
    {
        List<T> GetList();

        T GetById(long id);

        void Delete(T entity);

        void Update(T entity);

        void Insert(T entity);
    }
}