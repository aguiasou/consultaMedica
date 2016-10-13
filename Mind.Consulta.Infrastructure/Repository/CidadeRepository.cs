using Mind.Consulta.Domain.BusinessObject;
using Mind.Consulta.Domain.IRepositories;

namespace Mind.Consulta.Infrastructure.Repository
{
    public class CidadeRepository : Repository<Cidade>, ICidadeRespository
    {
        public CidadeRepository(ConsultaContext contexto):base(contexto)
        {

        }
    }
}
