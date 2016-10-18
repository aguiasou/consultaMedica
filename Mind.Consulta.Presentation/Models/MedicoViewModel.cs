using Mind.Consulta.Domain.BusinessObject;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Mvc;

namespace Mind.Consulta.Presentation.Models
{
    public class MedicoViewModel : PessoaViewModel
    {
        [DisplayName("CRM")]
        public string Crm { get; set; }

        public long EspecialidadeId { get; set; }

        [DisplayName("Especialidade")]
        public SelectListItem Especialidades { get; set; }

        private readonly IEnumerable<EspecialidadeViewModel> especialidades;

        public MedicoViewModel()
        {
            this.especialidades = new List<EspecialidadeViewModel>();
            this.Especialidades = new SelectListItem();
            this.Endereco = new EnderecoViewModel();
        }

        public MedicoViewModel(IEnumerable<EspecialidadeViewModel> especialidades, IEnumerable<EstadoViewModel> estados) : this()
        {
            this.Endereco.d = endereco;
        }

        public MedicoViewModel(Medico medico, IEnumerable<EspecialidadeViewModel> especialidades, EnderecoViewModel endereco)
        {
            this.Nome = medico.Nome;
            this.Id = medico.Id;
            this.DataNascimento = medico.DataNascimento;
            this.Crm = medico.Crm;
            this.Endereco = new EnderecoViewModel
            {
                Complemento = medico.Endereco.Complemento,
                EnderecoId = medico.EnderecoId,
                CidadeId = medico.Id

            };

            this.EspecialidadeId = medico.EspecialidadeId;

            this.Cpf = medico.Cpf;

        }

        public Medico ConvertToMedico()
        {
            return new Medico
            {
                Cpf = this.Cpf,
                DataNascimento = this.DataNascimento,
                EnderecoId = this.Endereco.EnderecoId,
                Endereco = new Domain.BusinessObject.Endereco { Complemento = this.Endereco.Complemento, CidadeId = this.Endereco.CidadeId, Id = this.Endereco.EnderecoId },
                Id = this.Id,
                Nome = this.Nome,
                Crm = this.Crm,
                Sexo = this.Sexo,
                EspecialidadeId = this.EspecialidadeId,
                Especialidade = new Especialidade { Id = this.EspecialidadeId },


            };
        }

    }
}