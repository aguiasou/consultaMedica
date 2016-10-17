using System;
using System.Linq;
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


        [TestMethod]
        public async Task DeveAtualizarRegistroNoBanco()
        {
            //Arrange
            var especialidade = new Especialidade { Descricao = "Dermatologista" };
            await this.especialidadeRepository.Save(especialidade);

            var especialidadeAtualizada = await this.especialidadeRepository.FindById(especialidade.Id);
            especialidadeAtualizada.Descricao = "Ginecologista";

            //Action
            await this.especialidadeRepository.Save(especialidadeAtualizada);

            //Assert
            Assert.IsNotNull(especialidadeAtualizada);
            Assert.AreEqual(especialidadeAtualizada.Id, especialidade.Id);
            Assert.AreEqual(especialidadeAtualizada.Descricao, "Ginecologista");
        }

        [TestMethod]
        public async Task  DeveDeletarRegistroNoBanco()
        {
            //Arrange
            var especialidade = new Especialidade { Descricao = "Urologista" };
            await this.especialidadeRepository.Save(especialidade);


            //Action
            await this.especialidadeRepository.Delete(especialidade);
            var especialidadeDeletada =  await this.especialidadeRepository.FindById(especialidade.Id);

            //Assert
            Assert.IsNull(especialidadeDeletada);
        }

        [TestMethod]
        public async Task DeveConsultarRegistroById()
        {
            //Arrange
            var especialidade = new Especialidade { Descricao = "Ortopedista" };
            await this.especialidadeRepository.Save(especialidade);


            //Action
            var especialidadeConsultada = await this.especialidadeRepository.FindById(especialidade.Id);


            //Assert
            Assert.IsNotNull(especialidadeConsultada);
            Assert.AreEqual(especialidadeConsultada.Id, especialidade.Id);
            Assert.AreEqual(especialidadeConsultada.Descricao, especialidade.Descricao);
        }

        [TestMethod]
        public async Task DeveConsultarRegistroByDescricao()
        {
            //Arrange
            var especialidade = new Especialidade { Descricao = "Oftalmologista" };
            await this.especialidadeRepository.Save(especialidade);


            //Action
            var especialidadeConsultada =  (await this.especialidadeRepository.Find(e=>e.Descricao == "Oftalmologista")).FirstOrDefault();


            //Assert
            Assert.IsNotNull(especialidadeConsultada);
            Assert.AreEqual(especialidadeConsultada.Id, especialidade.Id);
            Assert.AreEqual(especialidadeConsultada.Descricao, especialidade.Descricao);

        }

    }
}
