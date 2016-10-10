using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mind.Consulta.Domain.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Consulta.Test.Spec
{
    [TestClass]
    public class BeneficiarioSpec
    {
        [TestMethod]
        public void DeveIndicarSeEhResponsavel()
        {
            //Arrange
            var beneficiario = new Beneficiario
            {
                DataNascimento = DateTime.Now.AddYears(-19)
            };

            //Action
            var isResponsavel = beneficiario.IsResponsavel;


            //Assert
            Assert.IsTrue(isResponsavel);
        }

        [TestMethod]
        public void DeveIndicarSeNaoEhResponsavel()
        {
            //Arrange
            var beneficiario = new Beneficiario
            {
                DataNascimento = DateTime.Now.AddYears(-10)
            };
    
            //Action
        var isResponsavel = beneficiario.IsResponsavel;


            //Assert
            Assert.IsFalse(isResponsavel);
        }
    }
}
