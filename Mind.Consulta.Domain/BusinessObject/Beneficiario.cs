using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Consulta.Domain.BusinessObject
{
    public class Beneficiario : PessoaFisica
    {
        public const int MAIORIDADE = 18;
        public string NumeroCarteira { get; set; }

        public int Idade
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(base.DataNascimento).Ticks).Year - 1;
            }
        }

        public bool IsResponsavel
        {
            get
            {
                return this.Idade > MAIORIDADE;
            }
        }

    }
}
