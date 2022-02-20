using AssignmentManagement.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AssignmentManagement.Core.Utilities.CustomResult;

namespace AssignmentManagement.Business.Abstract
{
    public interface IService<T, TM> where T : class, IDbTable where TM:IDto
    {
        Task<IDataResult<TM>> GetAsync (Expression<Func<T, bool>> filter);
        Task<IDataResult<IEnumerable<TM>>> GetAllAsync(Expression<Func<T, bool>> filter = null); 
        IDataResult<T> Get(Expression<Func<T, bool>> filter);
        Task<IDataResult<TM>> AddAsync(TM entity);
        IDataResult<TM> Add(TM entity);
        Task<IResult> AddRangeAsync(IEnumerable<TM> entities);
        IResult Update(T entity);
        Task<IResult> RemoveAsync(TM entity);
        Task<IResult> RemoveRangeAsync(IEnumerable<TM> entities);
    }
}
