using Microsoft.EntityFrameworkCore;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected ProjetoModeloDDDContext _context  = new ProjetoModeloDDDContext();//{ get; }//
        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }
        public IEnumerable<TEntity> GetAllAsNoTracking()
        {
            return _context.Set<TEntity>().AsNoTracking();
        }
        public void Save(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();
        }
        public void Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Delete(TEntity obj)
        {
            _context.Set<TEntity>().Remove(obj);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
