﻿using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Interfaces
{
    public interface IAppServiceBase<TEntity> where TEntity : class
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
