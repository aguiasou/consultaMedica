using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Consulta.Domain.BusinessObject
{
    public class Pessoa: Entidade
    {
        public string Nome { get; set; }
        
        public Endereco Endereco { get; set; }

        public long EnderecoId { get; set; }

        public Pessoa()
        {

        }

    }
}
