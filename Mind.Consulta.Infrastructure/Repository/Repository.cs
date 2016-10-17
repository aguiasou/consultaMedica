using Mind.Consulta.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Mind.Consulta.Domain.BusinessObject;

namespace Mind.Consulta.Infrastructure.Repository
{
    public class Repository<TEntity> : IRepository<TEntity>
                                        where TEntity : Entidade
    {
        private readonly ConsultaContext contexto;

        public Repository(ConsultaContext contexto)
        {
            this.contexto = contexto;
        }

        public async Task Delete(TEntity entity)
        {
            await Task.Factory.StartNew(() =>
            {
                this.contexto.Set<TEntity>().Remove(entity);
                this.contexto.SaveChanges();
            });
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
            if (entity.Id != default(long))
                await this.Update(entity);
            else await this.Insert(entity);
        }

        private async Task Insert(TEntity entity)
        {
            await Task.Factory.StartNew(() =>
            {
                this.contexto.Set<TEntity>().Add(entity);
                this.contexto.SaveChanges();
            });

           
        }

        private async Task Update(TEntity entity)
        {
            await Task.Factory.StartNew(() =>
            {
                this.contexto.Set<TEntity>().Attach(entity);
                this.contexto.SaveChanges();
            });
        }
    }
}
