using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Models
{
    public class Item
    {
        public Item()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdItem { get; set; }

        public int IdCubeItem { get; set; }

        [ForeignKey("IdCubeItem")]
        public virtual Cube CubeItem { get; set; }

        [MinLength(1)]
        [MaxLength(100)]
        [Required(ErrorMessage = "Necessário adicionar um Nome ao Item.")]
        public string NomeItem { get; set; }

        [MinLength(1)]
        [MaxLength(500)]
        [Required(ErrorMessage = "Necessário adicionar uma Descrição ao Item.")]
        public string DescricaoItem { get; set; }

        [MinLength(1)]
        [MaxLength(10)]
        [Required(ErrorMessage = "Necessário adicionar uma Raridade ao Item.")]
        public string RaridadeItem { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        [Required(ErrorMessage = "Necessário adicionar um Rank ao Item.")]
        public string RankItem { get; set; }

        [MinLength(1)]
        [MaxLength(20)]
        [Required(ErrorMessage = "Necessário adicionar um Tipo ao Item.")]
        public string TipoItem { get; set; }

        [MinLength(1)]
        [MaxLength(20)]
        [Required(ErrorMessage = "Necessário adicionar um Status ao Item.")]
        public string StatusItem { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade HP ao Item.")]
        public int HpItem { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade MP ao Item.")]
        public int MpItem { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade DMGF ao Item.")]
        public int DmgfItem { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade DMGM ao Item.")]
        public int DmgmItem { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade DEF ao Item.")]
        public int DefItem { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade FUR ao Item.")]
        public int FurItem { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade DET ao Item.")]
        public int DetItem { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade CRIT ao Item.")]
        public int CritItem { get; set; }

        [MinLength(1)]
        [MaxLength(3)]
        [Required(ErrorMessage = "Necessário adicionar uma quantidade ACR ao Item.")]
        public int AcrItem { get; set; }

        public virtual ICollection<OminiSkill> OminiSkillItem { get; set; }
    }
}