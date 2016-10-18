using Mind.Consulta.Domain.BusinessObject;
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

        public long EnderecoId { get;  set; }
        public long CidadeId { get; set; }
        public long EstadoId { get; set; }


        [DisplayName("Complemento")]
        public string Complemento { get; set; }

        private IEnumerable<EstadoViewModel> estados;
        private IEnumerable<CidadeViewModel> cidades;


        public EnderecoViewModel(IEnumerable<EstadoViewModel> estados)
        {
            this.estados = estados;
        }

        public EnderecoViewModel(IEnumerable<EstadoViewModel> estados, IEnumerable<CidadeViewModel> cidades):this(estados)
        {
            this.cidades = cidades;
        }

        public EnderecoViewModel()
        {
            this.estados = new List<EstadoViewModel>();

        }

    }
}
