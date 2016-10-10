using Mind.Consulta.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Consulta.Domain.Services
{
    public class ServicoMarcarConsulta
    {
        private readonly IConsultaRespository consultaRepository;

        public ServicoMarcarConsulta(IConsultaRespository consultaRepository)
        {
            this.consultaRepository = consultaRepository;
        }


        public bool IsConsultaExists(Consulta.Domain.BusinessObject.Consulta consulta)
        {


            //var cons = consultaRepository.Find(c=>c.Medico.Id == consulta.Medico.Id 
            //                                    &&
            throw new NotImplementedException();
        }

        public void MarcarConsulta(Consulta.Domain.BusinessObject.Consulta consulta)
        {
           
        }
    }
}
