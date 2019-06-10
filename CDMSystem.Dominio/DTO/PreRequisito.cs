using System.ComponentModel.DataAnnotations;

namespace CDMSystem.Dominio.DTO
{
    public class PreRequisito : DTODefault
    {
        public PreRequisito()
        {

        }

        [Key]
        public int IdPreRequisito { get; set; }

        public string DescricaoPreRequisito { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (string.IsNullOrEmpty(DescricaoPreRequisito))
            {
                AddError("O campo Descrição do Pré-requisito não foi informado.");
            }
        }
    }
}