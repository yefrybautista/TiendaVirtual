using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
   public interface IGenericServices<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        bool Add(T entity);
        bool Update(T entity,int Id);
        bool Delete(int id);
    }
}
