using Mind.Consulta.Domain.BusinessObject;
using Mind.Consulta.Domain.IRepositories;
using Mind.Consulta.Infrastructure.Repository;

namespace Mind.Consulta.Infrastructure.Repository
{
    public class MedicoRepository : Repository<Medico>, IMedicoRepository
    {
        public MedicoRepository(ConsultaContext contexto):base(contexto)
        {

        }
    }
}
