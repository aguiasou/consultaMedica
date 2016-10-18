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

        public MedicoViewModel() : base()
        {
            this.especialidades = new List<EspecialidadeViewModel>();
            this.Especialidades = new SelectListItem();
        }

        public MedicoViewModel(IEnumerable<EspecialidadeViewModel> especialidades, IEnumerable<EstadoViewModel> estados) : base(estados)
        {
            this.especialidades = especialidades;
        }

        public MedicoViewModel(Medico medico, IEnumerable<EspecialidadeViewModel> especialidades, IEnumerable<EstadoViewModel> estados, IEnumerable<CidadeViewModel> cidades) :
                          base(medico.Endereco, estados, cidades)
        {
            this.Nome = medico.Nome;
            this.Id = medico.Id;
            this.DataNascimento = medico.DataNascimento;
            this.Crm = medico.Crm;
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