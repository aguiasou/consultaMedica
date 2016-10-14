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
        public static IEnumerable<object> FindInstancesByNamespace<T>(this T type) 
        {
            return typeof(T).Assembly.GetTypes()
                            .Where(t=>t.IsClass &&  !t.IsAbstract)
                            .Select(t => Activator.CreateInstance(t)).ToList();
        }
    }
}
