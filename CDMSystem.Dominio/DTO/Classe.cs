using System.Collections.Generic;
using System.Linq;

namespace CDMSystem.Dominio.DTO
{
    public class Classe : DTODefault
    {
        public Classe()
        {

        }

        public int IdClasse { get; set; }

        public string IdGuildClasse { get; set; }

        public virtual Guild GuildClasse { get; set; }

        public virtual ICollection<OminiSkill> OminiSkillClasse { get; set; }

        public string NomeClasse { get; set; }

        public string StatusClasse { get; set; }

        public string ArmaduraClasse { get; set; }

        public string ArmaPrimariaClasse { get; set; }

        public string ArmaSecundariaClasse { get; set; }

        public string PenalidadeClasse { get; set; }

        public string HabilidadePassivaClasse { get; set; }

        public int HpClasse { get; set; }

        public int MpClasse { get; set; }

        public int DmgfClasse { get; set; }

        public int DmgmClasse { get; set; }

        public int DefClasse { get; set; }

        public int FurClasse { get; set; }

        public int DetClasse { get; set; }

        public int CritClasse { get; set; }

        public int AcrClasse { get; set; }

        public string PericiaLaminasClasse { get; set; }

        public string PericiaLongaDistanciaClasse { get; set; }

        public string PericiaArremecoClasse { get; set; }

        public string PericiaCorpoCorpoClasse { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (string.IsNullOrEmpty(NomeClasse))
            {
                AddError("O campo Nome da Classe não foi informado.");
            }

            if (string.IsNullOrEmpty(StatusClasse))
            {
                AddError("O campo Status da Classe não foi informado.");
            }

            if (string.IsNullOrEmpty(ArmaduraClasse))
            {
                AddError("O campo Armadura da Classe não foi informado.");
            }

            if (string.IsNullOrEmpty(ArmaPrimariaClasse))
            {
                AddError("O campo Arma Primária da Classe não foi informado.");
            }

            if (string.IsNullOrEmpty(ArmaSecundariaClasse))
            {
                AddError("O campo Arma Secundária da Classe não foi informado.");
            }

            if (string.IsNullOrEmpty(PenalidadeClasse))
            {
                AddError("O campo Penalidade da Classe não foi informado.");
            }

            if (string.IsNullOrEmpty(HabilidadePassivaClasse))
            {
                AddError("O campo Habilidade Passiva da Classe não foi informado.");
            }

            if (HpClasse <= 0)
            {
                AddError("O campo HP da Classe não foi informado.");
            }

            if (MpClasse <= 0)
            {
                AddError("O campo MP da Classe não foi informado.");
            }

            if (DmgfClasse <= 0)
            {
                AddError("O campo DMGF da Classe não foi informado.");
            }

            if (DmgmClasse <= 0)
            {
                AddError("O campo DMGM da Classe não foi informado.");
            }

            if (FurClasse < 0)
            {
                AddError("O campo FUR da Classe não foi informado.");
            }

            if (DetClasse < 0)
            {
                AddError("O campo DET da Classe não foi informado.");
            }

            if (CritClasse < 0)
            {
                AddError("O campo CRIT da Classe não foi informado.");
            }

            if (AcrClasse < 0)
            {
                AddError("O campo ACR da Classe não foi informado.");
            }

            if (string.IsNullOrEmpty(PericiaLaminasClasse))
            {
                AddError("O campo Perícia com Lâminas da Classe não foi informado.");
            }

            if (string.IsNullOrEmpty(PericiaLongaDistanciaClasse))
            {
                AddError("O campo Perícia com Armas de Longa Distância da Classe não foi informado.");
            }

            if (string.IsNullOrEmpty(PericiaArremecoClasse))
            {
                AddError("O campo Perícia com Lâminas da Classe não foi informado.");
            }

            if (string.IsNullOrEmpty(PericiaCorpoCorpoClasse))
            {
                AddError("O campo Nome da Classe não foi informado.");
            }
        }
    }
}