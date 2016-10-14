//using Mind.Consulta.Domain.BusinessObject;
//using System.Data.Entity.ModelConfiguration;

//namespace Mind.Consulta.Infrastructure.Mapping
//{
//    public class MedicoMapping: EntityTypeConfiguration<Medico>
//    {
//        public MedicoMapping()
//        {
//            ToTable("Medico");
//            HasKey(m => m.Id);
//            Property(m => m.Nome);
//            Property(m => m.Cpf);
//            Property(m => m.Crm);
//            Property(m => m.DataNascimento);
//            Property(m => m.Sexo);
//            HasRequired(m => m.Endereco).WithMany().HasForeignKey(c => c.EnderecoId).WillCascadeOnDelete();
//            HasRequired(m => m.Especialidade).WithMany().HasForeignKey(c => c.EspecialidadeId);

//        }
//    }
//}
