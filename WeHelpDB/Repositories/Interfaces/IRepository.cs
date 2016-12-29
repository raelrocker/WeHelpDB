using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WeHelpDB.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
                                Func<IQueryable<TEntity>, 
                                IOrderedQueryable<TEntity>> orderBy = null,
                                string includeProperties = "");
        TEntity Find(params object[] key);
        void Update(TEntity obj);
        int SaveAll();
        int Save(TEntity obj);
        void Add(TEntity obj);
        void Delete(Func<TEntity, bool> predicate);
        void Delete(TEntity obj);
    }
}
