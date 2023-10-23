using DAL.Context;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly ContextoDb _context;
        public RepositoryBase(ContextoDb contexto)
        {
            _context = contexto;
        }
        public async Task<ICollection<T>> GetAll()
        {
            var collectionT = await _context.Set<T>().ToListAsync();
            return collectionT;
        }
        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public bool Create(T entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Added;
                _context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Deleted;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }



        public bool Update(T entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
