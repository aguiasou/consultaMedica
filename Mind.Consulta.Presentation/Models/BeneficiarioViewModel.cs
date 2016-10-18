using Mind.Consulta.Domain.BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Consulta.Presentation.Models
{
    public class BeneficiarioViewModel : PessoaViewModel
    {

        public string Nome { get; set; }


        public string NumeroCarteira { get; set; }



        public BeneficiarioViewModel()
        {

        }

        public BeneficiarioViewModel(Beneficiario beneficiario)
        {
            this.Nome = beneficiario.Nome;
            this.Id = beneficiario.Id;
            this.DataNascimento = beneficiario.DataNascimento;
            this.NumeroCarteira = beneficiario.NumeroCarteira;
            this.Endereco = new EnderecoViewModel
            {
                Complemento = beneficiario.Endereco.Complemento,
                EnderecoId = beneficiario.EnderecoId,
                CidadeId = beneficiario.Id

            };
            this.Idade = beneficiario.Idade;

            this.Cpf = beneficiario.Cpf;

        }

        public Beneficiario ConvertToBeneficiario()
        {
            return new Beneficiario
            {
                Cpf = this.Cpf,
                 DataNascimento = this.DataNascimento,
                 EnderecoId = this.Endereco.EnderecoId,
                 Endereco = new Domain.BusinessObject.Endereco { Complemento = this.Endereco.Complemento, CidadeId = this.Endereco.CidadeId, Id = this.Endereco.EnderecoId },
                 Id = this.Id,
                 Nome = this.Nome,
                 NumeroCarteira = this.NumeroCarteira,
                 Sexo = this.Sexo,
                 
            };
        }



    }
}
