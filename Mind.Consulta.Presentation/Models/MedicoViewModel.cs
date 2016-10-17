using System.ComponentModel;
using System.Web.Mvc;

namespace Mind.Consulta.Presentation.Models
{
    public class MedicoViewModel: PessoaViewModel
    {
        [DisplayName("CRM")]
        public string Crm { get; set; }


        public long EspecialidadeId { get; set; }

        [DisplayName("Especialidade")]
        public SelectListItem Especialidades { get; set; }

    }
}