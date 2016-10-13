using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace Mind.Consulta.Util.Extensions
{
    public static class ManageAssemblyExtension
    {
        public static IEnumerable<object> FindAll(this Type type) 
        {
            return typeof(Type).Assembly.GetTypes().Where(t=>t.IsClass).Select(t => Activator.CreateInstance(t)).ToList();
        }
    }
}
