using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<ICollection<T>> GetAll();
        T Get(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
