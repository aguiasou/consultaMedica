using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mind.Consulta.Domain.IRepositories;
using Mind.Consulta.Infrastructure.Repository;
using Mind.Consulta.Infrastructure;
using Mind.Consulta.Domain.BusinessObject;

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
        public async void DeveInserirNoBanco()
        {
            var estado = new Estado { Nome = "Espirito Santo", Sigla = "ES" };
            await this.estadoRepository.Save(estado);

            var estadoInserido = await this.estadoRepository.FindById(estado.Id);

            Assert.Equals(estado.Id, estadoInserido.Id);
            Assert.Equals(estado.Nome, estadoInserido.Nome);
            Assert.Equals(estado.Sigla, estadoInserido.Sigla);
        }

        [TestMethod]
        public void DeveLerRegistroNoBanco()
        {
        }

        [TestMethod]
        public void DeveAtualizarRegistroNoBanco()
        {
        }

        [TestMethod]
        public void DeveDeletarRegistroNoBanco()
        {
        }
    }
}
