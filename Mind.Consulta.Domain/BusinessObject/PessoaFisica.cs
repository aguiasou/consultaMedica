using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Consulta.Domain.BusinessObject
{
    public class PessoaFisica: Pessoa
    {

        public string Cpf { get; set; }

        public string Sexo { get; set; }

        public DateTime DataNascimento { get; set; }


    }
}
