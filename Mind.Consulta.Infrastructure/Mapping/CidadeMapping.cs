using Mind.Consulta.Domain.BusinessObject;
using System.Data.Entity.ModelConfiguration;

namespace Mind.Consulta.Infrastructure.Mapping
{
    public class CidadeMapping : EntityTypeConfiguration<Cidade>
    {
        public CidadeMapping()
        {
            ToTable("Cidade");
            HasKey(e => e.Id);
            Property(c => c.Nome);
            HasRequired(c => c.Estado).WithMany().HasForeignKey(c => c.EstadoId).WillCascadeOnDelete();


        }
    }
}
