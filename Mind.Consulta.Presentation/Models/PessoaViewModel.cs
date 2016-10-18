using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Mind.Consulta.Presentation.Models
{
    public abstract class PessoaViewModel
    {

        public PessoaViewModel()
        {
            this.Endereco = new EnderecoViewModel();
        }

        public PessoaViewModel(IEnumerable<EstadoViewModel> estados)
        {
            this.Endereco = new EnderecoViewModel(estados);
        }

        public PessoaViewModel(IEnumerable<EstadoViewModel> estados, IEnumerable<CidadeViewModel> cidades)
        {
            this.Endereco = new EnderecoViewModel(estados, cidades);
        }

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