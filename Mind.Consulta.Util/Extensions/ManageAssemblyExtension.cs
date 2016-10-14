using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Mind.Consulta.Util.Extensions
{
    public static class ManageAssemblyExtension
    {
        public static IEnumerable<object> FindInstances<T>(this T type, Func<Type, bool> expression) 
        {
            return typeof(T).Assembly.GetTypes().Where(expression).Select(t => Activator.CreateInstance(t)).ToList();
        }
    }
}
