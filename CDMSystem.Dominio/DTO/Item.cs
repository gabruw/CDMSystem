using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Dominio.DTO
{
    public class Item : DTODefault
    {
        public Item()
        {

        }

        [Key]
        public int IdItem { get; set; }

        public int IdCubeItem { get; set; }

        [ForeignKey("IdCubeItem")]
        public virtual Cube CubeItem { get; set; }

        public string NomeItem { get; set; }

        public string DescricaoItem { get; set; }

        public string RaridadeItem { get; set; }

        public string RankItem { get; set; }

        public string TipoItem { get; set; }

        public string StatusItem { get; set; }

        public int HpItem { get; set; }

        public int MpItem { get; set; }

        public int DmgfItem { get; set; }

        public int DmgmItem { get; set; }

        public int DefItem { get; set; }

        public int FurItem { get; set; }

        public int DetItem { get; set; }

        public int CritItem { get; set; }

        public int AcrItem { get; set; }

        public virtual ICollection<OminiSkill> OminiSkillItem { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (NomeItem.Length < 1)
            {
                AddError("O campo Nome do Item não foi informado.");
            }

            if (DescricaoItem.Length < 1)
            {
                AddError("O campo Descrição do Item não foi informado.");
            }

            if (RaridadeItem.Length < 1)
            {
                AddError("O campo Raridade do Item não foi informado.");
            }

            if (RankItem.Length < 1)
            {
                AddError("O campo Rank do Item não foi informado.");
            }

            if (TipoItem.Length < 1)
            {
                AddError("O campo Tipo do Item não foi informado.");
            }
        }
    }
}