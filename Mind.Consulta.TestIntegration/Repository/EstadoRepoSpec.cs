using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mind.Consulta.Domain.IRepositories;
using Mind.Consulta.Infrastructure.Repository;
using Mind.Consulta.Infrastructure;
using Mind.Consulta.Domain.BusinessObject;
using System.Threading.Tasks;
using System.Linq;

namespace Mind.Consulta.Test.Integration
{
    [TestClass]
    public class EstadoRepoSpec
    {

        private readonly IEstadoRepository estadoRepository;

        public EstadoRepoSpec()
        {
            var contexto = new ConsultaContext();
            this.estadoRepository = new EstadoRepository(contexto);
        }

        [TestMethod]
        public async Task DeveInserirNoBanco()
        {
            //Arrange
            var estado = new Estado { Nome = "Espírito Santo", Sigla = "ES" };

            //Action
            await this.estadoRepository.Save(estado);


            var estadoInserido = await this.estadoRepository.FindById(estado.Id);

            //Assert
            Assert.IsNotNull(estadoInserido);
            Assert.AreEqual(estadoInserido.Id, estado.Id);
            Assert.AreEqual(estadoInserido.Nome, estado.Nome);
            Assert.AreEqual(estadoInserido.Sigla, estado.Sigla);

        }


        [TestMethod]
        public async Task DeveAtualizarRegistroNoBanco()
        {
            //Arrange
            var estado = new Estado { Nome = "Espírito Santo", Sigla = "ES" };
            await this.estadoRepository.Save(estado);
            var estadoAtualizado = await this.estadoRepository.FindById(estado.Id);
            estadoAtualizado.Sigla = "SP";
            estadoAtualizado.Nome = "São Paulo";

            //Action
            await this.estadoRepository.Save(estadoAtualizado);



            //Assert
            Assert.IsNotNull(estadoAtualizado);
            Assert.AreEqual(estadoAtualizado.Id, estado.Id);
            Assert.AreEqual(estadoAtualizado.Nome, "São Paulo");
            Assert.AreEqual(estadoAtualizado.Sigla, "SP");
        }

        [TestMethod]
        public async Task DeveDeletarRegistroNoBanco()
        {
            //Arrange
            var estado = new Estado { Nome = "Teste", Sigla = "T" };
            await this.estadoRepository.Save(estado);


            //Action
            await this.estadoRepository.Delete(estado);
            var estadoDeletado = await this.estadoRepository.FindById(estado.Id);

            //Assert
            Assert.IsNull(estadoDeletado);
        }

        [TestMethod]
        public async Task DeveConsultarRegistroById()
        {
            //Arrange
            var estado = new Estado { Nome = "Minas Gerais", Sigla = "MG" };
            await this.estadoRepository.Save(estado);


            //Action
            var esptadoConsultado = await this.estadoRepository.FindById(estado.Id);


            //Assert
            Assert.IsNotNull(esptadoConsultado);
            Assert.AreEqual(esptadoConsultado.Id, estado.Id);
            Assert.AreEqual(esptadoConsultado.Nome, estado.Nome);
            Assert.AreEqual(esptadoConsultado.Sigla, estado.Sigla);
        }

        [TestMethod]
        public async Task DeveConsultarRegistroByNome()
        {
            //Arrange
            var estado = new Estado { Nome = "Rio de Janeiro", Sigla="RJ" };
            await this.estadoRepository.Save(estado);


            //Action
            var estadoConsultado = (await this.estadoRepository.Find(e => e.Nome == "Rio de Janeiro")).FirstOrDefault();


            //Assert
            Assert.IsNotNull(estadoConsultado);
            Assert.AreEqual(estadoConsultado.Id, estado.Id);
            Assert.AreEqual(estadoConsultado.Sigla, estado.Sigla);
            Assert.AreEqual(estadoConsultado.Nome, estado.Nome);

        }

        [TestMethod]
        public async Task DeveConsultarRegistroBySigla()
        {
            //Arrange
            var estado = new Estado { Nome = "Rio Grande do Sul", Sigla = "RS" };
            await this.estadoRepository.Save(estado);


            //Action
            var estadoConsultado = (await this.estadoRepository.Find(e => e.Sigla == "RS")).FirstOrDefault();


            //Assert
            Assert.IsNotNull(estadoConsultado);
            Assert.AreEqual(estadoConsultado.Id, estado.Id);
            Assert.AreEqual(estadoConsultado.Nome, estado.Nome);
            Assert.AreEqual(estadoConsultado.Sigla, estado.Sigla);

        }
    }
}
