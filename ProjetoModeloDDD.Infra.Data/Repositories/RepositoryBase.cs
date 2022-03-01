using Microsoft.EntityFrameworkCore;
using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        public ProjetoModeloDDDContext Context { get; set; }
        public TEntity GetById(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }
        public IEnumerable<TEntity> GetAllAsNoTracking()
        {
            return Context.Set<TEntity>().AsNoTracking().ToList();
        }
        public void Save(TEntity obj)
        {
            Context.Set<TEntity>().Add(obj);
            Context.SaveChanges();
        }
        public void Update(TEntity obj)
        {
            Context.Entry(obj).State = EntityState.Modified;
            Context.SaveChanges();
        }
        public void Delete(TEntity obj)
        {
            Context.Set<TEntity>().Remove(obj);
            Context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
