using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Consulta.Domain.BusinessObject
{
    public class Consulta : Entidade
    {
        public Beneficiario Beneficiario { get; set; }
        public Medico Medico { get; set; }
        public DateTime Data { get; set; }
        public int MedicoId { get; set; }
        public int BeneficiarioId { get; set; }
    }
}
