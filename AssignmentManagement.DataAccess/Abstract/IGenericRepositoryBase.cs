using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AssignmentManagement.Core.Entities.Abstract;

namespace AssignmentManagement.Core.DataAccess
{
    public interface IGenericRepositoryBase<T> where T:class,IDbTable
    {
        Task<T> GetAsync(Expression<Func<T,bool>> filter);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);
        IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        Task AddAsync(T entity);
        void Add(T entity); 
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
