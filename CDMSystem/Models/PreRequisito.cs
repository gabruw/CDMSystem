using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Models
{
    public class PreRequisito
    {
        public PreRequisito()
        {

        }

        [Key]
        [MinLength(11)]
        [MaxLength(11)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPreRequisito { get; set; }

        [MinLength(1)]
        [MaxLength(500)]
        [Required(ErrorMessage = "Necessário adicionar uma Descrição ao Pré-Requisito.")]
        public string DescricaoPreRequisito { get; set; }

        public int IdOminiSkillPreRequisito { get; set; }

        [ForeignKey("IdOminiSkillPreRequisito")]
        public virtual OminiSkill OminiSkillPreRequisito { get; set; }
    }
}