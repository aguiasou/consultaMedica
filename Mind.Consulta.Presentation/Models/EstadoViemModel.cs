using Mind.Consulta.Domain.BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Mind.Consulta.Presentation.Models
{
    public class EstadoViewModel
    {
        public long Id { get; private set; }

        [DisplayName("Nome")]
        public string Nome { get; set; }

        [DisplayName("Sigla")]
        public string Sigla { get; set; }

        public EstadoViewModel()
        {

        }

        public EstadoViewModel(Estado estado)
        {
            this.Id = estado.Id;
            this.Nome = estado.Nome;
            this.Sigla = estado.Sigla;
        }
    }
}
