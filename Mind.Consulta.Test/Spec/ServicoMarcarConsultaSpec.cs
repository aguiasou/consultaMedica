using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mind.Consulta.Domain.Services;
using Mind.Consulta.Test.Mock;

namespace Mind.Consulta.Test.Spec
{
    [TestClass]
    public class ServicoMarcarConsultaSpec
    {
        private readonly IServicoMarcarConsulta servicoMarcarConsulta;
        public ServicoMarcarConsultaSpec()
        {
            var consultaRepository = new MockConsultaRepository();
            this.servicoMarcarConsulta = new ServicoMarcarConsulta(consultaRepository)
        }

        [TestMethod]
        public void DeveRetornarVerdadeiroAoVerificarSeConsultaExiste()
        {

        }

        [TestMethod]
        public void DeveRetornarFalsoAoVerificarSeConsultaExiste()
        {
        }

        [TestMethod]
        public void DeveRetornarErroAoInserirConsulta()
        {
        }

    }
}
