//using System.Data.Entity.ModelConfiguration;

//namespace Mind.Consulta.Infrastructure.Mapping
//{
//    public class ConsultaMapping : EntityTypeConfiguration<Consulta.Domain.BusinessObject.Consulta>
//    {
//        public ConsultaMapping()
//        {
//            ToTable("Consulta");
//            HasKey(c => c.Id);
//            Property(c => c.Data);
//            HasRequired(c => c.Beneficiario).WithMany().HasForeignKey(c => c.BeneficiarioId);
//            HasRequired(c => c.Medico).WithMany().HasForeignKey(c => c.MedicoId);

//        }
//    }
//}
