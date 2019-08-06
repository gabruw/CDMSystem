using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Dominio.DTO
{
    public class MOB : DTODefault
    {
        public MOB()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public double Id { get; set; }

        #region Foreign Keys
        public double? IdRace { get; set; }

        [ForeignKey("IdRace")]
        public virtual Race MOBRace { get; set; }

        public double? IdSecret { get; set; }

        [ForeignKey("IdSecret")]
        public virtual ICollection<Secret> MOBSecret { get; set; }

        public double? IdClass { get; set; }

        [ForeignKey("IdClass")]
        public virtual Class MOBClass { get; set; }

        public double? IdActiveSkill { get; set; }

        [ForeignKey("IdActiveSkill")]
        public virtual ICollection<ActiveSkill> MOBActiveSkill { get; set; }

        public double? IdStatus { get; set; }

        [ForeignKey("IdStatus")]
        public virtual Status MOBStatus { get; set; }

        public double? IdEquipment { get; set; }

        [ForeignKey("IdEquipment")]
        public virtual Equipment MOBEquipment { get; set; }

        public double? IdSkillTree { get; set; }

        [ForeignKey("IdSkillTree")]
        public virtual SkillTree MOBSkillTree { get; set; }

        public double? IdSystem { get; set; }

        [ForeignKey("IdSystem")]
        public virtual System MOBSystem{ get; set; }
        #endregion

        public string Name { get; set; }

        public int? Level { get; set; }

        public int Sex { get; set; }

        public int TypeMOB { get; set; }

        public int Order { get; set; }

        public double? Size { get; set; }

        public double? Width { get; set; }

        public int Classification { get; set; }

        public string Description { get; set; }

        public string FirstSighting { get; set; }

        public string Addendums { get; set; }

        public string FinalStatement { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (string.IsNullOrEmpty(this.Name))
            {
                AddError("O campo Nome não foi informado.");
            }

            if (this.Sex.ToString().Length == 0)
            {
                AddError("O campo Sexo não foi informado.");
            }

            if (this.TypeMOB.ToString().Length == 0)
            {
                AddError("O campo Tipo não foi informado.");
            }

            if (this.Order.ToString().Length == 0)
            {
                AddError("O campo Ordem não foi informado.");
            }

            if (this.Classification.ToString().Length == 0)
            {
                AddError("O campo Classificação não foi informado.");
            }
        }
    }
}