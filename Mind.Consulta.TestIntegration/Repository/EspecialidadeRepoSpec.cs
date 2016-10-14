using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Mind.Consulta.Domain.BusinessObject;
using Mind.Consulta.Infrastructure;
using Mind.Consulta.Infrastructure.Repository;
using Mind.Consulta.Domain.IRepositories;

namespace Mind.Consulta.Test.Integration
{
    [TestClass]
    public class EspecialidadeRepoSpec
    {
        private readonly IEspecialidadeRepository especialidadeRepository;

        public EspecialidadeRepoSpec()
        {
            var contexto = new ConsultaContext();
            this.especialidadeRepository = new EspecialidadeRepository(contexto);
        }

        [TestMethod]
        public async Task DeveInserirNoBanco()
        {
            var especialidade = new Especialidade { Descricao = "Pediatria" };
            await this.especialidadeRepository.Save(especialidade);

            var especialidadeInserido = await this.especialidadeRepository.FindById(especialidade.Id);

            Assert.IsNotNull(especialidadeInserido);
            Assert.AreEqual(especialidadeInserido.Id, especialidade.Id);
            Assert.AreEqual(especialidadeInserido.Descricao, especialidade.Descricao);
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
