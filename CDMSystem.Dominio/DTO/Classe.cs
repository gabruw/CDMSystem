using System.Collections.Generic;
using System.Linq;

namespace CDMSystem.Dominio.DTO
{
    public class Classe : DTODefault
    {
        public int IdClasse { get; set; }

        public Guild IdGuild { get; set; }

        public ICollection<OminiSkill> OminiSkillClasse { get; set; }

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

        public int FurClasse { get; set; }

        public int DetClasse { get; set; }

        public int CritClasse { get; set; }

        public int AcrClasse { get; set; }

        public string LaminasClasse { get; set; }

        public string LongaDistanciaClasse { get; set; }

        public string ArremecoClasse { get; set; }

        public string CorpoCorpoClasse { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (!OminiSkillClasse.Any())
            {
                AddError("Uma classe precisa possuir Omini Skills.");
            }

            //if (string.IsNullOrEmpty())
            //{
            //    AddError("Uma classe precisa possuir ");
            //}
        }
    }
}