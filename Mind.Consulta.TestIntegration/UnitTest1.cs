using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mind.Consulta.Infrastructure.Mapping;
using Mind.Consulta.Util.Extensions;

namespace Mind.Consulta.Test.Integration
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mapping = new BeneficiarioMapping();
            var instances = mapping.FindInstancesByNamespace(mapping.GetType().Namespace);



            foreach (var item in instances)
            {

            }
        }
    }
}
