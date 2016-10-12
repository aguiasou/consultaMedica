using Mind.Consulta.Domain.BusinessObject;
using System.Data.Entity.ModelConfiguration;

namespace Mind.Consulta.Infrastructure.Mapping
{
    public class EspecialidadeMapping : EntityTypeConfiguration<Especialidade>
    {
        public EspecialidadeMapping()
        {
            ToTable("Especialidade");
            HasKey(e => e.Id);
            Property(e => e.Descricao);
        }
    }
}
