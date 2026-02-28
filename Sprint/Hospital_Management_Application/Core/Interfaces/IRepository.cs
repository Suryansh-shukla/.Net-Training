using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);
        List<T> GetAll();
        T GetById(int id);
        void Update(int Id, T entity);
        void Delete(int Id);
    }
}
