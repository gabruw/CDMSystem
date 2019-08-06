using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Dominio.DTO
{
    public class Group : DTODefault
    {
        public Group()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public double Id { get; set; }

        public double IdSystem { get; set; }

        [ForeignKey("IdSystem")]
        public virtual ICollection<System> GroupSystem { get; set; }

        public double IdCharacter { get; set; }

        [ForeignKey("IdCharacter")]
        public virtual ICollection<Character> GroupCharacter { get; set; }

        public double IdAdventureDiary { get; set; }

        [ForeignKey("IdAdventureDiary")]
        public virtual ICollection<AdventureDiary> GroupAdventureDiary { get; set; }

        public string Name { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (string.IsNullOrEmpty(this.Name))
            {
                AddError("O campo Nome não foi informado.");
            }
        }
    }
}