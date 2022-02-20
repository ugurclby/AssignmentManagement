using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AssignmentManagement.Core.Entities.Abstract;
using AssignmentManagement.DataAccess.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;

namespace AssignmentManagement.Core.DataAccess.EntityFramework
{
    public class EfGenericRepositoryBase<T> : IGenericRepositoryBase<T> where T:class,IDbTable,new()
    {
         protected readonly  AppDbContext _appDbContext;

         public EfGenericRepositoryBase(AppDbContext appDbContext)
         {
             _appDbContext = appDbContext;
         }

         public async Task<T> GetAsync(Expression<Func<T, bool>> filter)
         {
             return await _appDbContext.Set<T>().Where(filter).FirstOrDefaultAsync();
         }
         public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null)
         {
            return filter==null ? await _appDbContext.Set<T>().ToListAsync() : await _appDbContext.Set<T>().Where(filter).ToListAsync();
             
         }
        
        public  IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return filter==null ? _appDbContext.Set<T>().AsNoTracking().AsQueryable() : _appDbContext.Set<T>().Where(filter).AsNoTracking().AsQueryable();
            
            // AsNoTracking : Çektiği dataların memory alımını engeller.
        }
         
        public T Get(Expression<Func<T, bool>> filter)
        {
            return _appDbContext.Set<T>().Where(filter).FirstOrDefault();
        }

        public async Task AddAsync(T entity)
        {
            var id = await _appDbContext.AddAsync(entity);
        }

        public void Add(T entity)
        {
            _appDbContext.Add(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
             await _appDbContext.AddRangeAsync(entities);
        }

        public void Update(T entity)
        {
            try
            {
                _appDbContext.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified; 
                //var sonuc = _appDbContext.Update(entity);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
           _appDbContext.SaveChanges();
        }

        public void Remove(T entity)
        {
          _appDbContext.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
             _appDbContext.RemoveRange(entities);
        }
    }
}
