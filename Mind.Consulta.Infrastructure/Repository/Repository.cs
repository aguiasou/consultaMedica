using Mind.Consulta.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Mind.Consulta.Domain.BusinessObject;

namespace Mind.Consulta.Infrastructure.Repository
{
    public class Repository<TEntity> : IRepository<TEntity>
                                        where TEntity : Entidade
    {
        private ConsultaContext contexto;

        public Repository()
        {
            this.contexto = new ConsultaContext();
        }

        public async Task<IQueryable<TEntity>> Find(Expression<Func<TEntity, bool>> func)
        {
            return await Task.Factory.StartNew(() => this.contexto.Set<TEntity>().Where<TEntity>(func));
        }

        public async Task<IEnumerable<TEntity>> FindAll()
        {
            return await Task.Factory.StartNew(() => this.contexto.Set<TEntity>().ToList());
        }

        public async Task<TEntity> FindById(long id)
        {
            return await Task.Factory.StartNew(() => this.contexto.Set<TEntity>().FirstOrDefault(e => e.Id == id));
        }

        public async Task Save(TEntity entity)
        {
            await Task.Factory.StartNew(() =>
            {
                this.contexto.Set<TEntity>().Add(entity);
                this.contexto.SaveChanges();
            });
        }
    }
}
