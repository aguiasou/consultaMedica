using Mind.Consulta.Domain.BusinessObject;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Consulta.Infrastructure.Mapping
{
    public abstract class MappingEntity<T> : EntityTypeConfiguration<T> where T : Entidade
    {
    }
}
