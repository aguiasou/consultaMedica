using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mind.Consulta.Infrastructure.Repository;
using Mind.Consulta.Domain.BusinessObject;
using Mind.Consulta.Domain.IRepositories;
using System.Threading.Tasks;
using Mind.Consulta.Infrastructure;

namespace Mind.Consulta.Test.Integration
{
    [TestClass]
    public class BeneficiarioRepoSpec
    {
        private readonly IBeneficiarioRespository beneficiarioRepository;
        

        public BeneficiarioRepoSpec()
        {
            var contexto = new ConsultaContext();
            this.beneficiarioRepository = new BeneficiarioRepository(contexto);

        }

        [TestMethod]
        public async Task DeveInserirNoBanco()
        {
            var beneficiario = new Beneficiario { Nome = "Helaine Cristina de Jesus", Cpf = "11111111111", DataNascimento = new DateTime(1985, 04, 03), NumeroCarteira = "123232", Sexo = "Feminino" };
            await this.beneficiarioRepository.Save(beneficiario);

            var beneficiarioInserido = await this.beneficiarioRepository.FindById(beneficiario.Id);

            Assert.IsNotNull(beneficiarioInserido);


            Assert.Equals(beneficiario.Id, beneficiarioInserido.Id);
            Assert.Equals(beneficiario.Nome, beneficiarioInserido.Nome);
            Assert.Equals(beneficiario.Idade, beneficiarioInserido.Idade);
            Assert.Equals(beneficiario.Sexo, beneficiarioInserido.Sexo);

        }

        [TestMethod]
        public async Task DeveLerRegistroNoBanco()
        {
            var beneficiario = new Beneficiario { Nome = "Helaine Cristina de Jesus", Cpf = "11111111111", DataNascimento = new DateTime(1985, 04, 03), NumeroCarteira = "123232", Sexo = "Feminino" };
            await this.beneficiarioRepository.Save(beneficiario);

            var beneficiarioInserido = await this.beneficiarioRepository.FindById(beneficiario.Id);

            Assert.IsNotNull(beneficiarioInserido);


            Assert.Equals(beneficiario.Id, beneficiarioInserido.Id);
            Assert.Equals(beneficiario.Nome, beneficiarioInserido.Nome);
            Assert.Equals(beneficiario.Idade, beneficiarioInserido.Idade);
            Assert.Equals(beneficiario.Sexo, beneficiarioInserido.Sexo);
        }

        [TestMethod]
        public async Task DeveAtualizarRegistroNoBanco()
        {
            var beneficiario = new Beneficiario { Nome = "Helaine Cristina de Jesus", Cpf = "11111111111", DataNascimento = new DateTime(1985, 04, 03), NumeroCarteira = "123232", Sexo = "Feminino" };
            await this.beneficiarioRepository.Save(beneficiario);

            var beneficiarioInserido = await this.beneficiarioRepository.FindById(beneficiario.Id);

            Assert.IsNotNull(beneficiarioInserido);


            Assert.Equals(beneficiario.Id, beneficiarioInserido.Id);
            Assert.Equals(beneficiario.Nome, beneficiarioInserido.Nome);
            Assert.Equals(beneficiario.Idade, beneficiarioInserido.Idade);
            Assert.Equals(beneficiario.Sexo, beneficiarioInserido.Sexo);
        }

        [TestMethod]
        public async Task DeveDeletarRegistroNoBanco()
        {
            var beneficiario = new Beneficiario { Nome = "Helaine Cristina de Jesus", Cpf = "11111111111", DataNascimento = new DateTime(1985, 04, 03), NumeroCarteira = "123232", Sexo = "Feminino" };
            await this.beneficiarioRepository.Save(beneficiario);

            var beneficiarioInserido = await this.beneficiarioRepository.FindById(beneficiario.Id);

            Assert.IsNotNull(beneficiarioInserido);


            Assert.Equals(beneficiario.Id, beneficiarioInserido.Id);
            Assert.Equals(beneficiario.Nome, beneficiarioInserido.Nome);
            Assert.Equals(beneficiario.Idade, beneficiarioInserido.Idade);
            Assert.Equals(beneficiario.Sexo, beneficiarioInserido.Sexo);
        }
    }
}
