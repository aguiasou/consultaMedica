using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Mind.Consulta.Presentation.Models
{
    public class PessoaViewModel
    {
        public long Id { get; protected set; }

        [DisplayName("Nome")]
        public string Nome { get; set; }
        [DisplayName("CPF")]
        public string Cpf { get; set; }

        public EnderecoViewModel Endereco { get; set; }

        public String Sexo { get; set; }


        public int Idade { get; protected set; }


        [DisplayName("Data Nascimento")]
        public DateTime DataNascimento { get; set; }


    }
}