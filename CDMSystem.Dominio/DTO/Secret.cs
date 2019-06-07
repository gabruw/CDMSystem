﻿using System.Collections.Generic;

namespace CDMSystem.Dominio.DTO
{
    public class Secret : DTODefault
    {
        public int IdSecret { get; set; }

        public int IdOminiSkillSecret { get; set; }

        public virtual ICollection<OminiSkill> OminiSkillSecret { get; set; }

        public string NomeSecret { get; set; }

        public string DescricaoSecret { get; set; }

        public string TempoSecret { get; set; }

        public string TempoEsperaSecret { get; set; }

        public string BonusSecret { get; set; }

        public string BonusAposSecret { get; set; }

        public string AposSecret { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (string.IsNullOrEmpty(NomeSecret))
            {
                AddError("O campo Nome do Secret não foi informado.");
            }

            if (string.IsNullOrEmpty(DescricaoSecret))
            {
                AddError("O campo Descrição do Secret não foi informado.");
            }

            if (string.IsNullOrEmpty(TempoSecret))
            {
                AddError("O campo Tempo do Secret não foi informado.");
            }

            if (string.IsNullOrEmpty(TempoEsperaSecret))
            {
                AddError("O campo Tempo de Espera do Secret não foi informado.");
            }

            if (string.IsNullOrEmpty(BonusSecret))
            {
                AddError("O campo Bônus do Secret não foi informado.");
            }

            if (string.IsNullOrEmpty(BonusAposSecret))
            {
                AddError("O campo Bônus Após do Secret não foi informado.");
            }

            if (string.IsNullOrEmpty(AposSecret))
            {
                AddError("O campo Após do Secret não foi informado.");
            }
        }
    }
}