using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CDMSystem.Dominio.DTO
{
    public class Character : DTODefault
    {
        public Character()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public double Id { get; set; }

        #region Foreign Keys
        public double? IdRace { get; set; }

        [ForeignKey("IdRace")]
        public virtual Race CharacterRace { get; set; }

        public double? IdSecret { get; set; }

        [ForeignKey("IdSecret")]
        public virtual ICollection<Secret> CharacterSecret { get; set; }

        public double? IdClass { get; set; }

        [ForeignKey("IdClass")]
        public virtual Class CharacterClass { get; set; }

        public double? IdActiveSkill { get; set; }

        public double? IdStatus { get; set; }

        [ForeignKey("IdStatus")]
        public virtual Status CharacterStatus { get; set; }

        public double? IdEquipment { get; set; }

        [ForeignKey("IdEquipment")]
        public virtual Equipment MOBEquipment { get; set; }

        public double? IdSkillTree { get; set; }

        [ForeignKey("IdSkillTree")]
        public virtual SkillTree CharacterSkillTree { get; set; }

        public double? IdSystem { get; set; }

        [ForeignKey("IdSystem")]
        public virtual System CharacterSystem { get; set; }
        #endregion

        public string Name { get; set; }

        public int? Level { get; set; }

        public int Sex { get; set; }

        public int Order { get; set; }

        public int? OSP { get; set; }

        public int? SP { get; set; }

        public string History { get; set; }

        public string Addendums { get; set; }

        public override void Validate()
        {
            
        }
    }
}