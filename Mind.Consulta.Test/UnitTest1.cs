using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mind.Consulta.Domain.BusinessObject;
using Mind.Consulta.Util.Extensions;

namespace Mind.Consulta.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var obj = new Beneficiario();
            var instances = (obj).FindInstances(obj.GetType().Namespace);


            foreach(var item in instances)
            {
                
            }
        }
    }
}
