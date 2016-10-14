using Mind.Consulta.Domain.BusinessObject;
using System.Data.Entity.ModelConfiguration;

namespace Mind.Consulta.Infrastructure.Mapping
{
    public class EstadoMapping : EntityTypeConfiguration<Estado>
    {
        public EstadoMapping()
        {
            ToTable("Estado");
            HasKey(e => e.Id);
            Property(e => e.Nome);
            //HasMany(e => e.Cidades).WithMany().Map(e => e.MapRightKey("EstadoId"));
        }
    }
}
