using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Models
{
    public class Personagem
    {
        public Personagem()
        {

        }

        [Key]
        [MinLength(11)]
        [MaxLength(11)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPersonagem { get; set; }

        public int IdUsuarioPersonagem { get; set; }

        [ForeignKey("IdUsuarioPersonagem")]
        public virtual Usuario UsuarioPersonagem { get; set; }

        public int IdRacaPersonagem { get; set; }

        [ForeignKey("IdRacaPersonagem")]
        public virtual Raca RacaPersonagem { get; set; }

        public int IdSecretPersonagem { get; set; }

        [ForeignKey("IdSecretPersonagem")]
        public virtual Secret SecretPersonagem { get; set; }

        public int IdClassePersonagem { get; set; }

        [ForeignKey("IdClassePersonagem")]
        public virtual Classe ClassePersonagem { get; set; }

        public int IdActiveSkillPersonagem { get; set; }

        [ForeignKey("IdActiveSkillPersonagem")]
        public virtual ActiveSkill ActiveSkillPersonagem { get; set; }

        public int IdCubePersonagem { get; set; }

        [ForeignKey("IdCubePersonagem")]
        public virtual Cube CubePersonagem { get; set; }

        [MinLength(1)]
        [MaxLength(120)]
        [Required(ErrorMessage = "Necessário adicionar um Nome ao Personagem.")]
        public string NomePersonagem { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        [Required(ErrorMessage = "Necessário adicionar um Level ao Personagem.")]
        public int LevelPersonagem { get; set; }

        [MinLength(64)]
        [MaxLength(64)]
        public string ImagemPersonagem { get; set; }

        [MinLength(64)]
        [MaxLength(64)]
        public string MarkPersonagem { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade Omini Skill Points ao Personagem.")]
        public int OspPersonagem { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade Skill Points ao Personagem.")]
        public int SpPersonagem { get; set; }

        [MinLength(1)]
        [MaxLength(30)]
        [Required(ErrorMessage = "Necessário adicionar uma Ordem ao Personagem.")]
        public string OrdemPersonagem { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade de HP ao Personagem.")]
        public int HpPersonagem { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade de MP ao Personagem.")]
        public int MpPersonagem { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade de DMGF ao Personagem.")]
        public int DmgfPersonagem { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade de DMGM ao Personagem.")]
        public int DmgmPersonagem { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade de DEF ao Personagem.")]
        public int DefPersonagem { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade de FUR ao Personagem.")]
        public int FurPersonagem { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade de DET ao Personagem.")]
        public int DetPersonagem { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade de CRIT ao Personagem.")]
        public int CritPersonagem { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade de ACR ao Personagem.")]
        public int AcrPersonagem { get; set; }
    }
}