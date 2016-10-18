using Mind.Consulta.Domain.BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Mind.Consulta.Presentation.Models
{
    public class EnderecoViewModel
    {

        public long EnderecoId { get;  set; }

        [Required]
        public long CidadeId { get; set; }
        public long EstadoId { get; set; }


        [DisplayName("Complemento")]
        [Required]
        public string Complemento { get; set; }

        private IEnumerable<EstadoViewModel> estados;

        private IEnumerable<CidadeViewModel> cidades;

        [DisplayName("Estados")]
        public IEnumerable<SelectListItem> Estados { get { return estados.Select(e => new SelectListItem { Text = e.Sigla, Value = e.Id.ToString() }).ToList(); } }

        [DisplayName("Cidades")]
        public IEnumerable<SelectListItem> Cidades { get { return cidades.Select(c => new SelectListItem { Text = c.Nome, Value = c.CidadeId.ToString() }).ToList(); } }


        public EnderecoViewModel(IEnumerable<EstadoViewModel> estados):this()
        {
            this.estados = estados;
        }

        public EnderecoViewModel(Endereco endereco, IEnumerable<EstadoViewModel> estados, IEnumerable<CidadeViewModel> cidades):this(estados)
        {
            this.Complemento = endereco.Complemento;
            this.EstadoId = endereco.Cidade.EstadoId;
            this.CidadeId = endereco.CidadeId;
            this.cidades = cidades;
            this.EnderecoId = endereco.Id;
        }

        public EnderecoViewModel()
        {
            this.estados = new List<EstadoViewModel>();
            this.cidades = new List<CidadeViewModel>();

        }

    }
}
