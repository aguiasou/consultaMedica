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
        public static IEnumerable<Type> GetTypes(this Type type, Func<Type, bool> expression)
        {
            return type.Assembly.GetTypes().Where(expression).Select(t => t).ToList();
        }

        public static IEnumerable<object> GetInstances(this IEnumerable<Type> types)
        {
            return types.Select(t => Activator.CreateInstance(t)).ToList();
        }
    }
}
