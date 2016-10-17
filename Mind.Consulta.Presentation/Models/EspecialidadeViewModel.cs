using System.ComponentModel;
namespace Mind.Consulta.Presentation.Models

{
    public class EspecialidadeViewModel 
    {
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        public long EspecialidadeId { get; set; }
        
    }
}
