using System.Collections.Generic;

namespace CDMSystem.Dominio.DTO
{
    public class Secret : DTODefault
    {
        public int IdSecret { get; set; }

        public ICollection<OminiSkill> OminiSkillSecret { get; set; }

        public string NomeSecret { get; set; }

        public string DescricaoSecret { get; set; }

        public string TempoSecret { get; set; }

        public string TempoEsperaSecret { get; set; }

        public string BonusSecret { get; set; }

        public string BonusAposSecret { get; set; }

        public string AposSecret { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}