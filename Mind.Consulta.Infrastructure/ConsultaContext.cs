﻿using Mind.Consulta.Domain.BusinessObject;
using Mind.Consulta.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.Consulta.Infrastructure
{
    public class ConsultaContext: DbContext
    {
        public ConsultaContext():base("ConsultaDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BeneficiarioMapping())
                                       .Add(new CidadeMapping())
                                       .Add(new ConsultaMapping())
                                       .Add(new EspecialidadeMapping())
                                       .Add(new EstadoMapping())
                                       .Add(new EnderecoMapping())
                                       .Add(new MedicoMapping());
        }

        public DbSet<Beneficiario> Beneficiarios { get; set; }

        public DbSet<Cidade> Cidades { get; set; }

        public DbSet<Consulta.Domain.BusinessObject.Consulta> Consultas { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Especialidade> Especialidades { get; set; }

        public DbSet<Estado> Estados { get; set; }

        public DbSet<Medico> Medicos { get; set; }

        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<PessoaFisica> PessoaFisicas { get; set; }



    }
}
