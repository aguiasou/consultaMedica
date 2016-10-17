using System.ComponentModel;
using System.Web.Mvc;

namespace Mind.Consulta.Presentation.Models
{
    public class CidadeViewModel 
    {
        public long CidadeId { get; private set; }

        [DisplayName("Nome")]
        public string Nome { get; set; }

        public long EstadoId { get; set; }

        public SelectListItem Estados { get; set; }

    }
}
