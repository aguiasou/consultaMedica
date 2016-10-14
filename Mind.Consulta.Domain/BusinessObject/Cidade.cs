using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Consulta.Domain.BusinessObject
{
    public class Cidade : Entidade
    {
        public virtual string Nome { get; set; }

        public virtual Estado Estado { get; set; }
        public long EstadoId { get; set; }

    }
}
