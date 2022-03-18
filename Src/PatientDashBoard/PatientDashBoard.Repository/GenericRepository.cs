using PatientDashBoard.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PatientDashBoard.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    { 
        private readonly PatientDBContext _context = null;
        private readonly DbSet<T> _table = null;

        public GenericRepository()
        {
            this._context = new PatientDBContext();
            _table = _context.Set<T>();
        }

        public GenericRepository(PatientDBContext context)
        {
            this._context = context;
            _table = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _table.ToList();
        }

        public Task<T> GetById(int id) => _context.Set<T>().FindAsync(id);

        public Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate)
           => _context.Set<T>().FirstOrDefaultAsync(predicate);

        public T GetById(object id) => _table.Find(id);

        public void Insert(T obj) => _table.Add(obj);

        public void Update(T obj)
        {
            _table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = _table.Find(id);
            _table.Remove(existing);
        }

        public IEnumerable<T> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return _table.Where(predicate).ToList();
        }
        public void Save() => _context.SaveChanges();
    }
}
