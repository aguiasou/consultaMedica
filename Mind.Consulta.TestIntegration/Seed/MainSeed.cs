using Mind.Consulta.Domain.IRepositories;
using Mind.Consulta.Infrastructure;
using Mind.Consulta.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Consulta.Test.Integration.Seed
{
    public class MainSeed
    {
        private readonly IBeneficiarioRespository beneficiarioRepository;
        private readonly ICidadeRespository cidadeRepository;
        private readonly IConsultaRespository consultaRepository;
        private readonly IEnderecoRepository enderecoRepository;
        private readonly IEspecialidadeRepository especialidadeRepository;
        private readonly IEstadoRepository estadoRepository;
        private readonly IMedicoRepository medicoRepository;




        public MainSeed(ConsultaContext contexto)
        {
            this.beneficiarioRepository = new BeneficiarioRepository(contexto);
            this.cidadeRepository = new CidadeRepository(contexto);
            this.consultaRepository = new ConsultaRespository(contexto);
            this.enderecoRepository = new EnderecoRepository(contexto);
            this.especialidadeRepository = new EspecialidadeRepository(contexto);
            this.estadoRepository = new EstadoRepository(contexto);
            this.medicoRepository = new MedicoRepository(contexto);
        }
    }
}
