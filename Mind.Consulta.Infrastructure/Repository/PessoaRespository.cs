using Mind.Consulta.Domain.BusinessObject;
using Mind.Consulta.Domain.IRepositories;
using Mind.Consulta.Infrastructure.Repository;

namespace Mind.Consulta.Infrastructure.Repository
{
    public class PessoaRespository : Repository<Pessoa>, IPessoaRespository
    {
    }
}
