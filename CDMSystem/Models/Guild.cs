using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Models
{
    public class Guild
    {
        public Guild()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdGuild { get; set; }

        [MinLength(1)]
        [MaxLength(60)]
        [Required(ErrorMessage = "Necessário adicionar um Nome a Guild.")]
        public string NomeGuild { get; set; }

        [MinLength(1)]
        [MaxLength(500)]
        [Required(ErrorMessage = "Necessário adicionar uma Descrição a Guild.")]
        public string DescricaoGuild { get; set; }
    }
}