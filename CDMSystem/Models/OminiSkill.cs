using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Models
{
    public class OminiSkill
    {
        public OminiSkill()
        {

        }

        [Key]
        [MinLength(11)]
        [MaxLength(11)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOminiSkill { get; set; }

        public int IdClasseOminiSkill { get; set; }

        [ForeignKey("IdClasseOminiSkill")]
        public virtual Classe ClasseOminiSkill { get; set; }
        
        public int IdSecretOminiSkill { get; set; }

        [ForeignKey("IdSecretOminiSkill")]
        public virtual Secret SecretOminiSkill { get; set; }

        public int IdItemOminiSkill { get; set; }

        [ForeignKey("IdItemOminiSkill")]
        public virtual Item ItemOminiSkill { get; set; }

        [MinLength(1)]
        [MaxLength(120)]
        [Required(ErrorMessage = "Necessário adicionar um Nome a Omini Skill.")]
        public string NomeOminiSkill { get; set; }

        [MinLength(1)]
        [MaxLength(10)]
        [Required(ErrorMessage = "Necessário adicionar um Tipo a Omini Skill.")]
        public string TipoOminiSkill { get; set; }

        [MinLength(1)]
        [MaxLength(50)]
        [Required(ErrorMessage = "Necessário adicionar um Elemento a Omini Skill.")]
        public string ElementoOminiSkill { get; set; }

        [MinLength(1)]
        [MaxLength(500)]
        [Required(ErrorMessage = "Necessário adicionar uma Descrição a Omini Skill.")]
        public string DescricaoOminiSkill { get; set; }

        [MinLength(1)]
        [MaxLength(300)]
        [Required(ErrorMessage = "Necessário adicionar um Efeito a Omini Skill.")]
        public string EfeitoOminiSkill { get; set; }

        [MinLength(1)]
        [MaxLength(5)]
        [Required(ErrorMessage = "Necessário adicionar um Custo a Omini Skill.")]
        public string CustoOminiSkill { get; set; }

        [MinLength(1)]
        [MaxLength(15)]
        [Required(ErrorMessage = "Necessário adicionar uma Área a Omini Skill.")]
        public string AreaOminiSkill { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        [Required(ErrorMessage = "Necessário adicionar um Level a Omini Skill.")]
        public int LevelOminiSkill { get; set; }

        [MinLength(1)]
        [MaxLength(15)]
        [Required(ErrorMessage = "Necessário adicionar um Uso a Omini Skill.")]
        public string UsoOminiSkill { get; set; }

        public virtual ICollection<PreRequisito> PreRequisitoOminiSkill { get; set; }
    }
}