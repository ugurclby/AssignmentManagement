using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AssignmentManagement.Business.Abstract;
using AssignmentManagement.Core.DataAccess;
using AssignmentManagement.Core.DataAccess.UnitOfWorks;
using AssignmentManagement.Core.Entities.Abstract;
using AssignmentManagement.Core.Utilities.CustomResult;
using AssignmentManagement.Entities.Dtos;
using AutoMapper;

namespace AssignmentManagement.Business.Concrete
{
    public class ServiceManager<T,TM>:IService<T,TM> where T : class, IDbTable where TM:IDto
    {
        private readonly IGenericRepositoryBase<T> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ServiceManager(IGenericRepositoryBase<T> repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        } 
        public async Task<IDataResult<TM>> GetAsync (Expression<Func<T, bool>> filter)
        {
            var sonuc = await _repository.GetAsync(filter);
            var dto = _mapper.Map<TM>(sonuc);
            return new SuccessDataResult<TM>(dto, "Başarılı"); 
        }

        public async Task<IDataResult<IEnumerable<TM>>> GetAllAsync(Expression<Func<T, bool>> filter = null)
        {
            var sonuc = await _repository.GetAllAsync(filter);
            var dto = _mapper.Map<IEnumerable<TM>>(sonuc); 
            return new SuccessDataResult<IEnumerable<TM>>(dto, "Başarılı");
        } 

        public IDataResult<T> Get(Expression<Func<T, bool>> filter)
        {
            return new SuccessDataResult<T>(_repository.Get(filter), "Başarılı");

            //return new SuccessDataResult<TM>(  _mapper.Map<TM>(_repository.Get(filter)) ,  "Başarılı"); 
        }

        public async Task<IDataResult<TM>> AddAsync(TM entity)
        {
            var dto = _mapper.Map<T>(entity);
            await _repository.AddAsync(dto);
            await _unitOfWork.CommitAsync();
            return new SuccessDataResult<TM>(entity, "Başarılı");
        }

       
        public IDataResult<TM> Add(TM entity)
        {
            var dto = _mapper.Map<T>(entity);
            _repository.Add(dto);
             _unitOfWork.Commit();
            return new SuccessDataResult<TM>(entity, "Başarılı");
        }

        public async Task<IResult> AddRangeAsync(IEnumerable<TM> entities)
        {
            var dto = _mapper.Map<IEnumerable<T>>(entities);
            await _repository.AddRangeAsync(dto);
            await _unitOfWork.CommitAsync();
            return new Result(true, "Başarılı");
        }

        public IResult Update(T entity)
        {
            //var dto = _mapper.Map<T>(entity);
            //_repository.Update(dto);
            _repository.Update(entity);

            _unitOfWork.Commit();
            return new Result(true, "Başarılı");
        }

        public async Task<IResult> RemoveAsync(TM entity)
        {
            var dto = _mapper.Map<T>(entity);
            _repository.Remove(dto);
            await _unitOfWork.CommitAsync();
            return new Result(true, "Başarılı");
        }

        public async Task<IResult> RemoveRangeAsync(IEnumerable<TM> entities)
        {
            var dto = _mapper.Map<IEnumerable<T>>(entities);
            _repository.RemoveRange(dto);
            await _unitOfWork.CommitAsync();
            return new Result(true, "Başarılı");
        }
    }
}
