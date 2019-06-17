using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Models
{
    public class RaceSkill
    {
        public RaceSkill()
        {

        }

        [Key]
        [MinLength(11)]
        [MaxLength(11)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRaceSkill { get; set; }

        public int IdRaca { get; set; }

        [ForeignKey("IdRaca")]
        public virtual Raca RacaRaceSkill { get; set; }

        [MinLength(1)]
        [MaxLength(120)]
        [Required(ErrorMessage = "Necessário adicionar um Nome a Race Skill.")]
        public string NomeRaceSkill { get; set; }

        [MinLength(1)]
        [MaxLength(10)]
        [Required(ErrorMessage = "Necessário adicionar um Tipo a Race Skill.")]
        public string TipoRaceSkill { get; set; }

        [MinLength(1)]
        [MaxLength(50)]
        [Required(ErrorMessage = "Necessário adicionar um Elemento a Race Skill.")]
        public string ElementoRaceSkill { get; set; }

        [MinLength(1)]
        [MaxLength(500)]
        [Required(ErrorMessage = "Necessário adicionar uma Descrição a Race Skill.")]
        public string DescricaoRaceSkill { get; set; }

        [MinLength(1)]
        [MaxLength(300)]
        [Required(ErrorMessage = "Necessário adicionar um Efeito a Race Skill.")]
        public string EfeitoRaceSkill { get; set; }

        [MinLength(1)]
        [MaxLength(5)]
        [Required(ErrorMessage = "Necessário adicionar um Custo a Race Skill.")]
        public string CustoRaceSkill { get; set; }

        [MinLength(1)]
        [MaxLength(15)]
        [Required(ErrorMessage = "Necessário adicionar uma Área a Race Skill.")]
        public string AreaRaceSkill { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        [Required(ErrorMessage = "Necessário adicionar um Level a Race Skill.")]
        public int LevelRaceSkill { get; set; }

        [MinLength(1)]
        [MaxLength(15)]
        [Required(ErrorMessage = "Necessário adicionar um Uso a Race Skill.")]
        public string UsoRaceSkill { get; set; }

        public virtual ICollection<PreRequisito> PreRequisitoRaceSkill { get; set; }
    }
}