using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mind.Consulta.Presentation.Models
{
    public class EnderecoViewModel
    {

        public long EnderecoId { get; private set; }
        public long CidadeId { get; set; }

        [DisplayName("Complemento")]
        public string Complemento { get; set; }

    }
}
