using System.ComponentModel.DataAnnotations;

namespace CDMSystem.Dominio.DTO
{
    public class Core : DTODefault
    {
        public Core()
        {

        }

        [Key]
        public int IdCore { get; set; }

        public string NomeCore { get; set; }

        public string DescricaoCore { get; set; }

        public string TipoCore { get; set; }

        public int HpCore { get; set; }

        public int MpCore { get; set; }

        public int DmgfCore { get; set; }

        public int DmgmCore { get; set; }

        public int DefCore { get; set; }

        public int FurCore { get; set; }

        public int DetCore { get; set; }

        public int CritCore { get; set; }

        public int AcrCore { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (string.IsNullOrEmpty(NomeCore))
            {
                AddError("O campo Nome do Core não foi informado.");
            }

            if (string.IsNullOrEmpty(DescricaoCore))
            {
                AddError("O campo Descrição do Core não foi informado.");
            }

            if (string.IsNullOrEmpty(TipoCore))
            {
                AddError("O campo Tipo do Core não foi informado.");
            }

            if (HpCore <= 0)
            {
                AddError("O campo HP do Core não foi informado.");
            }

            if (MpCore <= 0)
            {
                AddError("O campo MP do Core não foi informado.");
            }

            if (DmgfCore <= 0)
            {
                AddError("O campo DMGF do Core não foi informado.");
            }

            if (DmgmCore <= 0)
            {
                AddError("O campo DMGM do Core não foi informado.");
            }

            if (FurCore < 0)
            {
                AddError("O campo FUR do Core não foi informado.");
            }

            if (DetCore < 0)
            {
                AddError("O campo DET do Core não foi informado.");
            }

            if (CritCore < 0)
            {
                AddError("O campo CRIT do Core não foi informado.");
            }

            if (AcrCore < 0)
            {
                AddError("O campo ACR do Core não foi informado.");
            }
        }
    }
}