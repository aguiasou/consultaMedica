using Mind.Consulta.Domain.BusinessObject;
using Mind.Consulta.Domain.IRepositories;
using Mind.Consulta.Infrastructure.Repository;



namespace Mind.Consulta.Infrastructure.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(ConsultaContext contexto):base(contexto)
        {

        }
    }
}
