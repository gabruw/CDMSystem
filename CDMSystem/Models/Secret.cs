using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Models
{
    public class Secret
    {
        public Secret()
        {

        }

        [Key]
        [MinLength(11)]
        [MaxLength(11)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSecret { get; set; }

        public virtual ICollection<OminiSkill> OminiSkillSecret { get; set; }

        [MinLength(1)]
        [MaxLength(40)]
        [Required(ErrorMessage = "Necessário adicionar um Nome ao Secret.")]
        public string NomeSecret { get; set; }

        [MinLength(1)]
        [MaxLength(300)]
        [Required(ErrorMessage = "Necessário adicionar uma Descrição ao Secret.")]
        public string DescricaoSecret { get; set; }

        [MinLength(1)]
        [MaxLength(40)]
        [Required(ErrorMessage = "Necessário adicionar um Tempo ao Secret.")]
        public string TempoSecret { get; set; }

        [MinLength(1)]
        [MaxLength(40)]
        [Required(ErrorMessage = "Necessário adicionar um Tempo de Espera ao Secret.")]
        public string TempoEsperaSecret { get; set; }

        [MinLength(1)]
        [MaxLength(300)]
        [Required(ErrorMessage = "Necessário adicionar um Bônus ao Secret.")]
        public string BonusSecret { get; set; }

        [MinLength(1)]
        [MaxLength(300)]
        [Required(ErrorMessage = "Necessário adicionar um Bônus Após o Uso ao Secret.")]
        public string BonusAposSecret { get; set; }

        [MinLength(1)]
        [MaxLength(300)]
        [Required(ErrorMessage = "Necessário adicionar uma Descrição Pós Uso ao Secret.")]
        public string AposSecret { get; set; }
    }
}