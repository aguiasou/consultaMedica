using Mind.Consulta.Domain.BusinessObject;
using System.ComponentModel;
namespace Mind.Consulta.Presentation.Models

{
    public class EspecialidadeViewModel
    {
        #region Properties

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        public long EspecialidadeId { get; private set; }

        #endregion

        #region Methods

        public Especialidade ConvertToEspecialidade()
        {
            return new Especialidade
            {
                Descricao = this.Descricao,
                Id = EspecialidadeId
            };
        }

        #endregion


        #region Constructor

        public EspecialidadeViewModel(Especialidade especialidade)
        {

            this.Descricao = especialidade.Descricao;
            this.EspecialidadeId = especialidade.Id;
        }

        public EspecialidadeViewModel()
        {

        }

        #endregion

    }
}
