using Microsoft.EntityFrameworkCore;
using SmartStore.DB;
using SmartStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartStore.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : BaseEntity
    {
        private MyAppContext _db;
        public GenericRepository() {
            _db = new MyAppContext();
        }

        public virtual TEntity Create(TEntity entity)
        {
            using (var db = new MyAppContext())
            {
                entity.Id = Guid.NewGuid();
                TEntity ret = db.Set<TEntity>().Add(entity).Entity;
                db.SaveChanges();

                return ret;
            }
        }

        public virtual void Delete(Guid id)
        {
            using (var db = new MyAppContext())
            {
                var entity = GetById(id);
                db.Set<TEntity>().Remove(entity);
                db.SaveChanges();
            }
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            //using (var db = new MyAppContext())
            //{
                return _db.Set<TEntity>().AsNoTracking();
            //}
        }

        public virtual TEntity GetById(Guid id)
        {
            using (var db = new MyAppContext())
            {
                return db.Set<TEntity>().AsNoTracking().FirstOrDefault(e => e.Id.Equals(id));
            }
        }

        public virtual TEntity Update(TEntity entity)
        {
            using (var db = new MyAppContext())
            {
                var ret = db.Set<TEntity>().Update(entity).Entity;
                db.SaveChanges();

                return ret;
            }
        }
    }
}
