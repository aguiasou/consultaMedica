using Mind.Consulta.Domain.IRepositories;
using Mind.Consulta.Domain.Exception;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Consulta.Domain.Services
{
    public class ServicoMarcarConsulta : IServicoMarcarConsulta
    {
        private readonly IConsultaRespository consultaRepository;

        public ServicoMarcarConsulta(IConsultaRespository consultaRepository)
        {
            this.consultaRepository = consultaRepository;
        }


        public async Task<bool> ConsultaExists(Consulta.Domain.BusinessObject.Consulta consulta)
        {
            var dataInicio = consulta.Data.AddMinutes(-30);
            var dataFim = consulta.Data.AddMinutes(30);

            var consultaExiste = await consultaRepository.Find(c => c.Data > dataInicio && c.Data < dataFim && c.Medico.Crm == consulta.Medico.Crm);
            return consultaExiste.Any();
        }

        public async Task MarcarConsulta(Consulta.Domain.BusinessObject.Consulta consulta)
        {
            if ((await this.ConsultaExists(consulta)))
                throw new BusinessException("Existe consulta marcada no período informado. Necessário respeitar o intervalo de 30 minutos entre as consultas.");

            await consultaRepository.Save(consulta);
        }
    }
}
