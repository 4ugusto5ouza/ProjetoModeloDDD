using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAllAsNoTracking();
        void Save(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);
        void Dispose();
    }
}
