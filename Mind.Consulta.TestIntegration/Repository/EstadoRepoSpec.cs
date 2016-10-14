using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mind.Consulta.Domain.IRepositories;
using Mind.Consulta.Infrastructure.Repository;
using Mind.Consulta.Infrastructure;
using Mind.Consulta.Domain.BusinessObject;
using System.Threading.Tasks;

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
            var estado = new Estado { Nome = "Espirito Santo", Sigla = "ES" };
            await this.estadoRepository.Save(estado);

            var estadoInserido = await this.estadoRepository.FindById(estado.Id);

            Assert.IsNotNull(estadoInserido);
            Assert.AreEqual(estado.Id, estadoInserido.Id);
            Assert.AreEqual(estado.Nome, estadoInserido.Nome);
            Assert.AreEqual(estado.Sigla, estadoInserido.Sigla);
        }

        //[TestMethod]
        //public void DeveLerRegistroNoBanco()
        //{
        //}

        //[TestMethod]
        //public void DeveAtualizarRegistroNoBanco()
        //{
        //}

        //[TestMethod]
        //public void DeveDeletarRegistroNoBanco()
        //{
        //}
    }
}
