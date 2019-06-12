using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Dominio.DTO
{
    public class Raca : DTODefault
    {
        public Raca()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRaca { get; set; }

        public string NomeRaca { get; set; }

        public string BonusRaca { get; set; }

        public string RaceSkillRaca { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (string.IsNullOrEmpty(NomeRaca))
            {
                AddError("O campo Nome da Raça não foi informado.");
            }

            if (string.IsNullOrEmpty(BonusRaca))
            {
                AddError("O campo Bônus da Raça não foi informado.");
            }

            if (string.IsNullOrEmpty(RaceSkillRaca))
            {
                AddError("O campo Race Skill da Raça não foi informado.");
            }
        }
    }
}