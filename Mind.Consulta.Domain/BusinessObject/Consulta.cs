﻿using System;
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
        public long MedicoId { get; set; }
        public long BeneficiarioId { get; set; }

    }
}
