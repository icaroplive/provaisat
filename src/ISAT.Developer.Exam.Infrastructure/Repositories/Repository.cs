using ISAT.Developer.Exam.Core.Entities;
using ISAT.Developer.Exam.Core.Interfaces;
using ISAT.Developer.Exam.Infrastructure.ORM.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ISAT.Developer.Exam.Infrastructure.ORM.Repositories
{
    public class Repository<TEntity> : IDisposable, IRepository<TEntity> where TEntity : BaseEntity<TEntity>
    {
        #region properties

        protected EFContextDB Db;

        protected DbSet<TEntity> DbSet;

        #endregion

        #region ctor

        public Repository()
        {
            Db = new EFContextDB();
            DbSet = Db.Set<TEntity>();
        }

        #endregion

        #region methods

        public virtual void Insert(TEntity entity)
        {
            entity.SetLastAction("");
            DbSet.Add(entity);
            Db.SaveChanges();
        }

        public virtual void Delete(long id)
        {
            TEntity entity = DbSet.FirstOrDefault(t => t.Id == id);

            if (entity != null)
            {
                DbSet.Remove(entity);
                Db.SaveChanges();
            }
        }

        public virtual void Update(TEntity entity)
        {
            Db.Entry(entity).State = EntityState.Modified;

            entity.SetLastAction("");

            DbSet.Update(entity);
            Db.SaveChanges();
        }

        public virtual TEntity GetById(long id)
        {
            return DbSet.FirstOrDefault(p => p.Id == id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }
                
        public void Dispose()
        {
            Db.Dispose();
        }

        #endregion
    }
}