using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Models
{
    public class Classe
    {
        public Classe()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdClasse { get; set; }

        public int IdGuildClasse { get; set; }

        [ForeignKey("IdGuildClasse")]
        public virtual Guild GuildClasse { get; set; }

        public virtual ICollection<OminiSkill> OminiSkillClasse { get; set; }

        [MinLength(1)]
        [MaxLength(40)]
        [Required(ErrorMessage = "Necessário adicionar um Nome a Classe.")]
        public string NomeClasse { get; set; }

        [MinLength(1)]
        [MaxLength(40)]
        [Required(ErrorMessage = "Necessário adicionar um Status a Classe.")]
        public string StatusClasse { get; set; }

        [MinLength(1)]
        [MaxLength(40)]
        [Required(ErrorMessage = "Necessário adicionar um Tipo de Armadura a Classe.")]
        public string ArmaduraClasse { get; set; }

        [MinLength(1)]
        [MaxLength(60)]
        [Required(ErrorMessage = "Necessário adicionar um Tipo de Arma Primária a Classe.")]
        public string ArmaPrimariaClasse { get; set; }

        [MinLength(1)]
        [MaxLength(60)]
        [Required(ErrorMessage = "Necessário adicionar um Tipo de Arma Secundária a Classe.")]
        public string ArmaSecundariaClasse { get; set; }

        [MinLength(1)]
        [MaxLength(300)]
        [Required(ErrorMessage = "Necessário adicionar uma Penalidade a Classe.")]
        public string PenalidadeClasse { get; set; }

        [MinLength(1)]
        [MaxLength(300)]
        [Required(ErrorMessage = "Necessário adicionar uma Habilidade Passiva a Classe.")]
        public string HabilidadePassivaClasse { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade de HP a Classe.")]
        public int HpClasse { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade de MP a Classe.")]
        public int MpClasse { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade de DMGF a Classe.")]
        public int DmgfClasse { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade de DMGM a Classe.")]
        public int DmgmClasse { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade de DEF a Classe.")]
        public int DefClasse { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade de FUR a Classe.")]
        public int FurClasse { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade de DET a Classe.")]
        public int DetClasse { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade de CRIT a Classe.")]
        public int CritClasse { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade de ACR a Classe.")]
        public int AcrClasse { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        [Required(ErrorMessage = "Necessário adicionar uma Perícia com Lâminas a Classe.")]
        public string PericiaLaminasClasse { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        [Required(ErrorMessage = "Necessário adicionar uma Perícia com Longa Distância a Classe.")]
        public string PericiaLongaDistanciaClasse { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        [Required(ErrorMessage = "Necessário adicionar uma Perícia com Arremeço a Classe.")]
        public string PericiaArremecoClasse { get; set; }

        [MinLength(1)]
        [MaxLength(1)]
        [Required(ErrorMessage = "Necessário adicionar uma Perícia com Corpo a Corpo a Classe.")]
        public string PericiaCorpoCorpoClasse { get; set; }
    }
}