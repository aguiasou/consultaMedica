﻿using Mind.Consulta.Domain.BusinessObject;
using Mind.Consulta.Domain.IRepositories;

namespace Mind.Consulta.Infrastructure.Repository
{
    public class EspecialidadeRepository : Repository<Especialidade>, IEspecialidadeRepository
    {
        public EspecialidadeRepository(ConsultaContext contexto):base(contexto)
        {

        }
    }
}
