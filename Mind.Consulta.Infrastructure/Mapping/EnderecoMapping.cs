using Mind.Consulta.Domain.BusinessObject;
using System.Data.Entity.ModelConfiguration;

namespace Mind.Consulta.Infrastructure.Mapping
{
    public class EnderecoMapping : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMapping()
        {
            ToTable("Endereco");
            HasKey(e => e.Id);
            Property(e => e.Complemento);
            HasRequired(e => e.Cidade).WithMany().HasForeignKey(e => e.CidadeId);
        }

    }
}
