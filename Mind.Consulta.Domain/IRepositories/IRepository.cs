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
        Task<bool> Any(Expression<Func<TEntity, bool>> func);

    }

    //public class Teste : IRepository<int>       
    //{
    //    public Teste()
    //    {
    //        var l = new List<int>();

    //        l.First(
    //    }

    //    public Task<int> FindById(long id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<IEnumerable<int>> FindAll()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task Save(int entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Task<IQueryable<int>> Find(Func<int, bool> func)
    //    {
    //        func(
    //        throw new NotImplementedException();
    //    }
    //}
}
