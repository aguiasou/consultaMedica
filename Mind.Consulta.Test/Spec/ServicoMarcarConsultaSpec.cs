using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mind.Consulta.Domain.Services;
using Mind.Consulta.Test.Mock;
using Mind.Consulta.Domain.BusinessObject;
using System.Threading.Tasks;
using Mind.Consulta.Domain.IRepositories;
using Mind.Consulta.Domain.Exception;

namespace Mind.Consulta.Test.Spec
{
    [TestClass]
    public class ServicoMarcarConsultaSpec
    {
        private readonly IServicoMarcarConsulta servicoMarcarConsulta;
        private readonly IConsultaRespository consultaRepository;
        public ServicoMarcarConsultaSpec()
        {
            this.consultaRepository = new MockConsultaRepository();
            this.servicoMarcarConsulta = new ServicoMarcarConsulta(consultaRepository);
        }

        [TestMethod]
        public async Task DeveRetornarVerdadeiroAoVerificarSeConsultaExiste()
        {
            //Arrange
            var consulta = new Domain.BusinessObject.Consulta
            {
                Beneficiario = new Beneficiario { },
                Medico = new Medico { Crm = "123", Nome = "Medico 1" },
                Data = new DateTime(2016, 10, 10, 08, 45, 00)
            };

            //Action
            var consultaExists = await this.servicoMarcarConsulta.ConsultaExists(consulta);

            //Assert
            Assert.IsTrue(consultaExists);

        }

        [TestMethod]
        public async Task DeveRetornarFalsoAoVerificarSeConsultaExiste()
        {
            //Arrange
            var consulta = new Domain.BusinessObject.Consulta
            {
                Beneficiario = new Beneficiario { },
                Medico = new Medico { Crm = "123", Nome = "Medico 1" },
                Data = new DateTime(2016, 10, 10, 10, 00, 00)
            };

            //Action
            var consultaExists = await this.servicoMarcarConsulta.ConsultaExists(consulta);

            //Assert
            Assert.IsFalse(consultaExists);
        }


        [TestMethod]
        public async Task DeveInserirConsulta()
        {
            //Arrange
            var consulta = new Domain.BusinessObject.Consulta
            {
                Id = 4,
                Beneficiario = new Beneficiario { },
                Medico = new Medico { Crm = "123", Nome = "Medico 1" },
                Data = new DateTime(2016, 10, 10, 10, 00, 00)
            };

            //Action
            await this.servicoMarcarConsulta.MarcarConsulta(consulta);

            //Assert
            var consultaInserida = this.consultaRepository.Find(c => c.Id == consulta.Id);
            Assert.IsNotNull(consultaInserida);
        }

        //[TestMethod]
        //public async Task DeveLancarErroAoTentarInserirConsulta()
        //{
        //    //Arrange
        //    var consulta = new Domain.BusinessObject.Consulta
        //    {
        //        Id = 4,
        //        Beneficiario = new Beneficiario { },
        //        Medico = new Medico { Crm = "123", Nome = "Medico 1" },
        //        Data = new DateTime(2016, 10, 10, 09, 00, 00)
        //    };

        //    //Action
        //    Action marcarConsulta = () => this.servicoMarcarConsulta.MarcarConsulta(consulta);


        //    //Assert
        //    marcarConsulta.Invoke();

        //}

    }
}
