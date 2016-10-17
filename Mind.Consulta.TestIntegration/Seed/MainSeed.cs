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
            beneficiarioRepository.ClearAsync().Wait();


            this.cidadeRepository = new CidadeRepository(contexto);
            cidadeRepository.ClearAsync().Wait();

            this.consultaRepository = new ConsultaRespository(contexto);
            consultaRepository.ClearAsync().Wait();


            this.enderecoRepository = new EnderecoRepository(contexto);
            enderecoRepository.ClearAsync().Wait();

            this.especialidadeRepository = new EspecialidadeRepository(contexto);
            especialidadeRepository.ClearAsync().Wait();

            this.estadoRepository = new EstadoRepository(contexto);
            estadoRepository.ClearAsync().Wait();

            this.medicoRepository = new MedicoRepository(contexto);
            medicoRepository.ClearAsync().Wait();

        }
    }
}
