using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Dominio.DTO
{
    public class Section : DTODefault
    {
        public Section()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public double Id { get; set; }

        public double IdGroup { get; set; }

        [ForeignKey("IdGroup")]
        public virtual Group SectionGroup { get; set; }

        public double IdAddress { get; set; }

        [ForeignKey("IdAddress")]
        public virtual Address SectionAddress { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan Duration { get; set; }

        public int TypeSection { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (this.Date == null)
            {
                AddError("O campo Data não foi informado.");
            }

            if (this.Duration == null)
            {
                AddError("O campo Duração não foi informado.");
            }

            if (this.TypeSection.ToString().Length == 0)
            {
                AddError("O campo Tipo não foi informado.");
            }
        }
    }
}