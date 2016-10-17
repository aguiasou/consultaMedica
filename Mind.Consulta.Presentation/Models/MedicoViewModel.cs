using System.ComponentModel;

namespace Mind.Consulta.Presentation.Models
{
    public class MedicoViewModel: PessoaViewModel
    {
        [DisplayName("CRM")]
        public string Crm { get; set; }

        [DisplayName("")]

        public Estado Especialidade { get; set; }
        public long EspecialidadeId { get; set; }

    }
}