using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeHelpDB.Context;
using WeHelpDB.Repositories.Interfaces;

namespace WeHelpDB.Repositories.Abstract
{
    public  abstract class Repository<TEntity> : IDisposable, IRepository<TEntity> where TEntity : class
    {
        WeHelpContext context;
        DbSet<TEntity> DbSet;

        #region Constructor
        public Repository(WeHelpContext context)
        {
            this.context = context;
            this.DbSet = this.context.Set<TEntity>();
        }
        #endregion

        #region Methods IRepository
        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public virtual IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public virtual TEntity Find(params object[] key)
        {
            return DbSet.Find(key);
        }

        public virtual void Update(TEntity obj)
        {
            var entry = context.Entry(obj);
            if (entry.State == EntityState.Detached)
            {
                DbSet.Attach(obj);
            }
            context.Entry(obj).State = EntityState.Modified;
        }

        public virtual int SaveAll()
        {
            return context.SaveChanges();
        }

        public virtual int Save(TEntity obj)
        {
            DbSet.Add(obj);
            return this.SaveAll();
        }

        public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual void Delete(Func<TEntity, bool> predicate)
        {
            DbSet
                .Where(predicate).ToList()
                .ForEach(del => context.Set<TEntity>().Remove(del));
        }

        public virtual void Delete(TEntity obj)
        {
            var entry = context.Entry(obj);
            if (entry.State == EntityState.Detached)
            {
                DbSet.Attach(obj);
            }
            context.Entry(obj).State = EntityState.Deleted;
        }

        #endregion

        #region IDisposable
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
