using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;

namespace MI.Data
{
    public class EFRepository<T> : IRepository<T> where T: class
    {
        private readonly DbContext _context;
        private DbSet<T> _entities;

        public EFRepository(DbContext context)
        {
            _context = context;
        } 

        // private set 
        // to access the entites
        private DbSet<T> Entities
        {
            get { return _entities ?? (_entities = _context.Set<T>()); }
        }

        public void Create(T entity)
        {
            Entities.Add(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            Entities.Remove(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Copy(T source, T target)
        {
            throw new NotImplementedException(); // implement it later
        }

        public T Get(int id)
        {
            return Entities.Find(id);
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            // Returns the only element of a sequence, 
            // or a default value if the sequence is empty; 
            // this method throws an exception if there is more than one element in the sequence.
            return Fetch(predicate).SingleOrDefault(); 
        }

        public IQueryable<T> Table
        {
            get { return Entities; }
        }

        public int Count(Expression<Func<T, bool>> predicate)
        {
            return Fetch(predicate).Count();
        }

        public IEnumerable<T> Fetch(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate);
        }
    }
}
