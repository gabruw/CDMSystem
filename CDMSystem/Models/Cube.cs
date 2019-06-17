using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Models
{
    public class Cube
    {
        public Cube()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCube { get; set; }

        public virtual ICollection<Item> ItemCube { get; set; }

        [MinLength(1)]
        [MaxLength(4)]
        [Required(ErrorMessage = "Necessário adicionar uma Quantidade de Itens ao Cube.")]
        public int QuantidadeItemCube { get; set; }

        [MinLength(1)]
        [MaxLength(10)]
        [Required(ErrorMessage = "Necessário adicionar um Status do Item ao Cube.")]
        public string StatusItemCube { get; set; }
    }
}