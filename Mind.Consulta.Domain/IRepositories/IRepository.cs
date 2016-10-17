using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mind.Consulta.Domain.IRepositories
{
    public interface IRepository<TEntity>
    {
        Task<TEntity> FindById(long id);
        Task<IEnumerable<TEntity>> FindAll();
        Task Save(TEntity entity);
        Task<IQueryable<TEntity>> Find(Expression<Func<TEntity, bool>> func);
        Task Delete(TEntity entity);

    }

}
