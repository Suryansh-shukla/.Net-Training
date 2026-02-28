using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);
        List<T> GetAll();
        T GetById(int Id);
        void Update(int Id,T entity);
        void Delete(int Id);
    }
}
