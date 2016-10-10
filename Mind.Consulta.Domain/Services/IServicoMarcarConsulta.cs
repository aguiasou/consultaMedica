using System.Threading.Tasks;
using Mind.Consulta.Domain.BusinessObject;

namespace Mind.Consulta.Domain.Services
{
    public interface IServicoMarcarConsulta
    {
        Task<bool> ConsultaExists(BusinessObject.Consulta consulta);
        Task MarcarConsulta(BusinessObject.Consulta consulta);
    }
}