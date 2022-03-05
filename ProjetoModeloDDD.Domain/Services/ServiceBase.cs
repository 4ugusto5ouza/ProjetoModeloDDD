using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }
        public IEnumerable<TEntity> GetAllAsNoTracking()
        {
            return _repository.GetAllAsNoTracking();
        }
        public void Save(TEntity obj)
        {
            _repository.Save(obj);
        }
        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }
        public void Delete(TEntity obj)
        {
            _repository.Delete(obj);
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
