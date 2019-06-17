using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Dominio.DTO
{
    public class RaceSkill : DTODefault
    {
        public RaceSkill()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRaceSkill { get; set; }

        public int IdRaca { get; set; }

        [ForeignKey("IdRaca")]
        public virtual Raca RacaRaceSkill { get; set; }

        public string NomeRaceSkill { get; set; }

        public string TipoRaceSkill { get; set; }

        public string ElementoRaceSkill { get; set; }

        public string DescricaoRaceSkill { get; set; }

        public string EfeitoRaceSkill { get; set; }

        public string CustoRaceSkill { get; set; }

        public string AreaRaceSkill { get; set; }

        public int LevelRaceSkill { get; set; }

        public string UsoRaceSkill { get; set; }

        public virtual ICollection<PreRequisito> PreRequisitoRaceSkill { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (string.IsNullOrEmpty(NomeRaceSkill))
            {
                AddError("O campo Nome da RaceSkill não foi informado.");
            }

            if (string.IsNullOrEmpty(TipoRaceSkill))
            {
                AddError("O campo Tipo da RaceSkill não foi informado.");
            }

            if (string.IsNullOrEmpty(DescricaoRaceSkill))
            {
                AddError("O campo Descrição da RaceSkill não foi informado.");
            }

            if (string.IsNullOrEmpty(EfeitoRaceSkill))
            {
                AddError("O campo Efeito da RaceSkill não foi informado.");
            }

            if (string.IsNullOrEmpty(CustoRaceSkill))
            {
                AddError("O campo Custo da RaceSkill não foi informado.");
            }

            if (string.IsNullOrEmpty(AreaRaceSkill))
            {
                AddError("O campo Área da RaceSkill não foi informado.");
            }

            if (LevelRaceSkill < 0)
            {
                AddError("O campo Level da RaceSkill não foi informado.");
            }

            if (string.IsNullOrEmpty(UsoRaceSkill))
            {
                AddError("O campo Uso da RaceSkill não foi informado.");
            }
        }
    }
}