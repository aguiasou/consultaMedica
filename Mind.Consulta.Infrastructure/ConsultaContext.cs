using Mind.Consulta.Domain.BusinessObject;
using Mind.Consulta.Infrastructure.Mapping;
using Mind.Consulta.Util.Extensions;
using System;
using System.Collections.Generic;
using System.Data.Entity;

using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Mind.Consulta.Infrastructure
{
    public class ConsultaContext : DbContext
    {


        public ConsultaContext() : base("ConsultaDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.Configurations.Add(new BeneficiarioMapping())
            //                           .Add(new CidadeMapping())
            //                           .Add(new ConsultaMapping())
            //                           .Add(new EspecialidadeMapping())
            //                           .Add(new EstadoMapping())
            //                           .Add(new EnderecoMapping())
            //                           .Add(new MedicoMapping());
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<Beneficiario> Beneficiarios { get; set; }

        public DbSet<Cidade> Cidades { get; set; }

        public DbSet<Consulta.Domain.BusinessObject.Consulta> Consultas { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Especialidade> Especialidades { get; set; }

        public DbSet<Estado> Estados { get; set; }

        public DbSet<Medico> Medicos { get; set; }




    }
}
