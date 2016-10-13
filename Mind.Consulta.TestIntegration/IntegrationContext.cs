using Mind.Consulta.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Consulta.Test.Integration
{
    public class IntegrationContext
    {
        protected readonly ConsultaContext contexto;
        public IntegrationContext()
        {
            var initializer = new DropCreateDatabaseAlways<ConsultaContext>();
            this.contexto = new ConsultaContext();
            initializer.InitializeDatabase(contexto);
        }



    }
}
