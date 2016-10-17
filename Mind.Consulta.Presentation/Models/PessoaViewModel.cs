using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Mind.Consulta.Presentation.Models
{
    public class PessoaViewModel
    {
        public long Id { get; set; }

        [DisplayName("Nome")]
        public string Nome { get; set; }
        public EnderecoViewModel Endereco { get; set; }

    }
}