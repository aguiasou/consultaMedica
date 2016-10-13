using Mind.Consulta.Domain.IRepositories;
using Mind.Consulta.Infrastructure.Repository;



namespace Mind.Consulta.Infrastructure.Repository
{
    public class ConsultaRespository : Repository<Consulta.Domain.BusinessObject.Consulta>, IConsultaRespository
    {
        public ConsultaRespository(ConsultaContext contexto):base(contexto)
        {

        }
    }
}
