using ProjetoModeloDDD.Application.Interfaces;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.AppServices
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity>, IDisposable where TEntity : class
    {
        private readonly IServiceBase<TEntity> _service;

        public AppServiceBase(IServiceBase<TEntity> service)
        {
            _service = service;
        }

        public TEntity GetById(int id)
        {
            return _service.GetById(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _service.GetAll();
        }
        public IEnumerable<TEntity> GetAllAsNoTracking()
        {
            return _service.GetAllAsNoTracking();
        }
        public void Save(TEntity obj)
        {
            _service.Save(obj);
        }
        public void Update(TEntity obj)
        {
            _service.Update(obj);
        }
        public void Delete(TEntity obj)
        {
            _service.Delete(obj);
        }

        public void Dispose()
        {
            _service.Dispose();
        }
    }
}
