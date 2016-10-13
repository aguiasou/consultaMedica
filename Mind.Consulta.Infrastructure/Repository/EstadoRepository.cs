using Mind.Consulta.Domain.BusinessObject;
using Mind.Consulta.Domain.IRepositories;
namespace Mind.Consulta.Infrastructure.Repository
{
    public class EstadoRepository : Repository<Estado>, IEstadoRepository
    {
        public EstadoRepository(ConsultaContext contexto):base(contexto)
        {

        }
    }
}
