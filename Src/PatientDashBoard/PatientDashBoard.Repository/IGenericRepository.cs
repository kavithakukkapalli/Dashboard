using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PatientDashBoard.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
        IEnumerable<T> GetWhere(Expression<Func<T, bool>> predicate);
    }
}
