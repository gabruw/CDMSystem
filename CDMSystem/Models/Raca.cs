using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Models
{
    public class Raca
    {
        public Raca()
        {

        }

        [Key]
        [MinLength(11)]
        [MaxLength(11)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRaca { get; set; }

        [MinLength(1)]
        [MaxLength(40)]
        [Required(ErrorMessage = "Necessário adicionar um Nome a Raça.")]
        public string NomeRaca { get; set; }

        [MinLength(1)]
        [MaxLength(300)]
        [Required(ErrorMessage = "Necessário adicionar um Bônus a Raça.")]
        public string BonusRaca { get; set; }

        public virtual ICollection<RaceSkill> RaceSkillRaca { get; set; }
    }
}