using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Dominio.DTO
{
    public class ActiveSkill : DTODefault
    {
        public ActiveSkill()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdActiveSkill { get; set; }

        public string NomeActiveSkill { get; set; }

        public string DescricaoActiveSkill { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (string.IsNullOrEmpty(NomeActiveSkill))
            {
                AddError("O campo Nome da Active Skill não foi informado.");
            }

            if (string.IsNullOrEmpty(DescricaoActiveSkill))
            {
                AddError("O campo Descrição da Active Skill não foi informado.");
            }
        }
    }
}