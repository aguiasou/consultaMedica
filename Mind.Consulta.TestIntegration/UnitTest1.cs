using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mind.Consulta.Domain.BusinessObject;
using Mind.Consulta.Infrastructure.Mapping;
using Mind.Consulta.Util.Extensions;
using System.Data.Entity.ModelConfiguration;
using System.Reflection;

namespace Mind.Consulta.Test.Integration
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var instances = typeof(BeneficiarioMapping).GetTypes(t => t.Namespace == typeof(BeneficiarioMapping).Namespace &&  t.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>))
                                                       .GetInstances();


            foreach (var item in instances)
            {

            }
        }
    }
}
