using Mind.Consulta.Domain.IRepositories;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mind.Consulta.Domain.BusinessObject;
using System.Linq.Expressions;
using System.Reflection;

namespace Mind.Consulta.Test.Mock
{
    public class MockConsultaRepository : IConsultaRespository
    {
        private IList<Consulta.Domain.BusinessObject.Consulta> consultas;

        public MockConsultaRepository()
        {
            var medico = new Medico { Crm = "123", Nome = "Medico 1" };
            var beneficiario = new Beneficiario { };

            this.consultas = new List<Consulta.Domain.BusinessObject.Consulta>
            {
                new Domain.BusinessObject.Consulta {  Beneficiario = new Beneficiario(), Medico = medico, Data = new DateTime(2016,10,10,08,00,00) },
                new Domain.BusinessObject.Consulta {  Beneficiario = new Beneficiario(), Medico = medico, Data = new DateTime(2016,10,10,08,30,00) },
                new Domain.BusinessObject.Consulta {  Beneficiario = new Beneficiario(), Medico = medico, Data = new DateTime(2016,10,10,09,30,00) },


            };
        }

        public async Task Delete(Domain.BusinessObject.Consulta entity)
        {
            await Task.Factory.StartNew(() => this.consultas.Remove(entity));
        }

        public async Task<IQueryable<Domain.BusinessObject.Consulta>> Find(Expression<Func<Domain.BusinessObject.Consulta, bool>> func)
        {
            return await Task.Factory.StartNew(() => this.consultas.AsQueryable().Where(func));
        }

        public async Task<IEnumerable<Domain.BusinessObject.Consulta>> FindAll()
        {
            return await Task.Factory.StartNew(() => this.consultas.AsEnumerable());
        }

        public async Task<Domain.BusinessObject.Consulta> FindById(long id)
        {
            return await Task.Factory.StartNew(() => this.consultas.FirstOrDefault(x=>x.Id== id));
        }

        public async Task Save(Domain.BusinessObject.Consulta entity)
        {
             await Task.Factory.StartNew(() => this.consultas.Add(entity));
        }
    }
}
