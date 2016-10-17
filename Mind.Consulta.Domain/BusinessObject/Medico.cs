using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Consulta.Domain.BusinessObject
{
    public class Medico: PessoaFisica
    {
        public string Crm { get; set; }
        public Estado Especialidade { get; set; }
        public long EspecialidadeId { get; set; }

    }
}
