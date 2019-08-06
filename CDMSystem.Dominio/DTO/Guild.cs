using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Dominio.DTO
{
    public class Guild : DTODefault
    {
        public Guild()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public double Id { get; set; }

        public double IdClass { get; set; }

        [ForeignKey("IdClass")]
        public virtual ICollection<Class> GuildClass { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (string.IsNullOrEmpty(this.Name))
            {
                AddError("O campo Nome não foi informado.");
            }

            if (string.IsNullOrEmpty(this.Description))
            {
                AddError("O campo Descrição não foi informado.");
            }
        }
    }
}