using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Mind.Consulta.Domain.IRepositories;
using Mind.Consulta.Infrastructure;
using Mind.Consulta.Infrastructure.Repository;
using Mind.Consulta.Domain.BusinessObject;
using System.Linq;

namespace Mind.Consulta.Test.Integration
{
    [TestClass]
    public class CidadeRespoSpec
    {
        private readonly ICidadeRespository cidadeRepository;
        private readonly IEstadoRepository estadoRepository;


        public CidadeRespoSpec()
        {
            var contexto = new ConsultaContext();
            this.estadoRepository = new EstadoRepository(contexto);
            this.cidadeRepository = new CidadeRepository(contexto);

        }

        [TestMethod]
        public async Task DeveInserirNoBanco()
        {
            //Arrange
            var estado = new Estado { Nome = "Espírito Santo", Sigla = "ES" };
            await this.estadoRepository.Save(estado);
            var cidade = new Cidade { Nome = "Vitória", Estado = estado, EstadoId = estado.Id };

            //Action
            await this.cidadeRepository.Save(cidade);

            var cidadeInserida = await this.cidadeRepository.FindById(cidade.Id);

            //Assert
            Assert.IsNotNull(cidadeInserida);
            Assert.AreEqual(cidadeInserida.Id, cidade.Id);
            Assert.AreEqual(cidadeInserida.Nome, cidade.Nome);
            Assert.AreEqual(cidadeInserida.EstadoId, cidade.EstadoId);

        }

        [TestMethod]
        public async Task DeveAtualizarRegistroNoBanco()
        {
            //Arrange
            var estado = new Estado { Nome = "Minas Gerais", Sigla = "MG" };
            await this.estadoRepository.Save(estado);
            var cidade = new Cidade { Nome = "Belo Horizonte", Estado = estado, EstadoId = estado.Id };
            await this.cidadeRepository.Save(cidade);

            cidade.Nome = "Ipatinga";
            //Action
            await this.cidadeRepository.Save(cidade);
            var cidadeAtualizada = await this.cidadeRepository.FindById(cidade.Id);

            //Assert
            Assert.IsNotNull(cidadeAtualizada);
            Assert.AreEqual(cidadeAtualizada.Id, cidade.Id);
            Assert.AreEqual(cidadeAtualizada.Nome, cidade.Nome);
            Assert.AreEqual(cidadeAtualizada.EstadoId, cidade.EstadoId);
        }

        [TestMethod]
        public async Task DeveDeletarRegistroNoBanco()
        {
            //Arrange
            var estado = new Estado { Nome = "Rio de Janeiro", Sigla = "RJ" };
            await this.estadoRepository.Save(estado);
            var cidade = new Cidade { Nome = "Rio de Janeiro", Estado = estado, EstadoId = estado.Id };
            await this.cidadeRepository.Save(cidade);

            //Action
            await this.cidadeRepository.Delete(cidade);
            var cidadeDeletada = await this.cidadeRepository.FindById(cidade.Id);

            //Assert
            Assert.IsNull(cidadeDeletada);
        }

        [TestMethod]
        public async Task DeveConsultarRegistroById()
        {
            //Arrange
            var estado = new Estado { Nome = "São Paulo", Sigla = "SP" };
            await this.estadoRepository.Save(estado);
            var cidade = new Cidade { Nome = "São Paulo", Estado = estado, EstadoId = estado.Id };

            //Action
            await this.cidadeRepository.Save(cidade);

            var cidadeInserida = await this.cidadeRepository.FindById(cidade.Id);

            //Assert
            Assert.IsNotNull(cidadeInserida);
            Assert.AreEqual(cidadeInserida.Id, cidade.Id);
            Assert.AreEqual(cidadeInserida.Nome, cidade.Nome);
            Assert.AreEqual(cidadeInserida.EstadoId, cidade.EstadoId);
        }

        [TestMethod]
        public async Task DeveConsultarRegistroByNome()
        {
            //Arrange
            var estado = new Estado { Nome = "Rio Grande do Sul", Sigla = "RS" };
            await this.estadoRepository.Save(estado);
            var cidade = new Cidade { Nome = "Porto Alegre", Estado = estado, EstadoId = estado.Id };

            //Action
            await this.cidadeRepository.Save(cidade);

            var cidadePesquisada = (await this.cidadeRepository.Find(c=> c.Nome == "Porto Alegre")).FirstOrDefault();

            //Assert
            Assert.IsNotNull(cidadePesquisada);
            Assert.AreEqual(cidadePesquisada.Id, cidade.Id);
            Assert.AreEqual(cidadePesquisada.Nome, cidade.Nome);
            Assert.AreEqual(cidadePesquisada.EstadoId, cidade.EstadoId);
        }

        [TestMethod]
        public async Task DeveConsultarRegistroBySiglaUf()
        {
            //Arrange
            var estado = new Estado { Nome = "Bahia", Sigla = "BA" };
            await this.estadoRepository.Save(estado);
            var cidade = new Cidade { Nome = "Salvador", Estado = estado, EstadoId = estado.Id };
            await this.cidadeRepository.Save(new Cidade { Nome = "Salvador", Estado = estado, EstadoId = estado.Id });
            await this.cidadeRepository.Save(new Cidade { Nome = "Teixeira de Freitas", Estado = estado, EstadoId = estado.Id });


            var cidadesPesquisadas = (await this.cidadeRepository.Find(c => c.Estado.Sigla == "BA")).ToList();

            //Assert
            Assert.IsNotNull(cidadesPesquisadas);
            Assert.AreEqual(cidadesPesquisadas.Count(), 2);
            
        }

        [TestMethod]
        public async Task DeveConsultarRegistroByEstadoId()
        {
            //Arrange
            var estado = new Estado { Nome = "Paraná", Sigla = "PR" };
            await this.estadoRepository.Save(estado);
            await this.cidadeRepository.Save(new Cidade { Nome = "Curitiba", Estado = estado, EstadoId = estado.Id });


            var cidadesPesquisadas = (await this.cidadeRepository.Find(c => c.Estado.Id == estado.Id)).ToList();

            //Assert
            Assert.IsNotNull(cidadesPesquisadas);
            Assert.AreEqual(cidadesPesquisadas.Count(), 1);

        }

    }
}
