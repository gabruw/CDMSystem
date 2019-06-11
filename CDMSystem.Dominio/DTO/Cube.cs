using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Dominio.DTO
{
    public class Cube : DTODefault
    {
        public Cube()
        {

        }

        [Key]
        public int IdCube { get; set; }

        public virtual ICollection<Item> ItemCube { get; set; }

        public int QuantidadeItemCube { get; set; }

        public string StatusItemCube { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (QuantidadeItemCube < 0)
            {
                AddError("O campo Quantidade do Item do Cube não foi informado.");
            }

            if (StatusItemCube.Length < 1)
            {
                AddError("O campo Status do Item do Cube não foi informado.");
            }
        }
    }
}