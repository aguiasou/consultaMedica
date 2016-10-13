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
        public static IEnumerable<object> FindInstances<T>(this T type, string nameSpace) 
        {
            return typeof(T).Assembly.GetTypes().Where(t=>t.IsClass &&  !t.IsAbstract && t.Namespace == nameSpace).Select(t => Activator.CreateInstance(t)).ToList();
        }
    }
}
