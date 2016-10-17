using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Mind.Consulta.Presentation.Models
{
    public class Consulta 
    {
        public long BeneficiarioId { get; set; }

        public BeneficiarioViewModel Beneficiario { get; set; }

        public MedicoViewModel Medico { get; set; }

        public long MedicoId { get; set; }

        [DisplayName("Data Agendamento")]
        public DateTime Data { get; set; }

        public SelectListItem Especialidades { get; set; }

        public SelectListItem Medicos { get; set; }



    }
}
