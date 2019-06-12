using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Dominio.DTO
{
    public class PreRequisito : DTODefault
    {
        public PreRequisito()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPreRequisito { get; set; }

        public string DescricaoPreRequisito { get; set; }

        public int IdOminiSkillPreRequisito { get; set; }

        [ForeignKey("IdOminiSkillPreRequisito")]
        public virtual OminiSkill OminiSkillPreRequisito { get; set; }

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