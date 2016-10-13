using Mind.Consulta.Domain.IRepositories;

namespace Mind.Consulta.Infrastructure.Repository
{
    public class ConsultaRespository : Repository<Consulta.Domain.BusinessObject.Consulta>, IConsultaRespository
    {
        public ConsultaRespository(ConsultaContext contexto):base(contexto)
        {

        }
    }
}
