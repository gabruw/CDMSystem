using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Models
{
    public class ActiveSkill
    {
        public ActiveSkill()
        {

        }

        [Key]
        [MinLength(11)]
        [MaxLength(11)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdActiveSkill { get; set; }

        [MinLength(1)]
        [MaxLength(120)]
        [Required(ErrorMessage = "Necessário adicionar um Nome a Active Skill.")]
        public string NomeActiveSkill { get; set; }

        [MinLength(1)]
        [MaxLength(500)]
        [Required(ErrorMessage = "Necessário adicionar uma descrição a Active Skill.")]
        public string DescricaoActiveSkill { get; set; }
    }
}