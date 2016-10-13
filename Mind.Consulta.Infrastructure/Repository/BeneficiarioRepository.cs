using Mind.Consulta.Domain.BusinessObject;
using Mind.Consulta.Domain.IRepositories;


namespace Mind.Consulta.Infrastructure.Repository
{
    public class BeneficiarioRepository: Repository<Beneficiario>, IBeneficiarioRespository
    {
        public BeneficiarioRepository(ConsultaContext contexto ):base(contexto)
        {

        }
    }
}
