
using Mind.Consulta.Domain.BusinessObject;
using System.Data.Entity.ModelConfiguration;

namespace Mind.Consulta.Infrastructure.Mapping
{
    public class BeneficiarioMapping:MappingEntity<Beneficiario>
    {
        public BeneficiarioMapping()
        {
            ToTable("Beneficiario");
            HasKey(m => m.Id);
            Property(m => m.Nome);
            Property(m => m.Cpf);
            Property(m => m.DataNascimento);
            Property(m => m.Sexo);
            HasRequired(m => m.Endereco).WithMany().HasForeignKey(c => c.EnderecoId).WillCascadeOnDelete();
        }
    }

   
}

