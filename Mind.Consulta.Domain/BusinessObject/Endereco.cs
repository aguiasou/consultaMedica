using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Consulta.Domain.BusinessObject
{
    public class Endereco : Entidade
    {
        public virtual Cidade Cidade { get; set; }
        public long CidadeId { get; set; }
        public string Complemento { get; set; }

    }
}
