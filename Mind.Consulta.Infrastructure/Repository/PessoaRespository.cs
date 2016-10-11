using Mind.Consulta.Domain.BusinessObject;
using Mind.Consulta.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Consulta.Domain.IRepositories
{
    public class PessoaRespository : Repository<Pessoa>, IPessoaRespository
    {
    }
}
