using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CDMSystem.Dominio.DTO
{
    public class Personagem : DTODefault
    {
        public Personagem()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPersonagem { get; set; }

        public int IdUsuarioPersonagem { get; set; }

        [ForeignKey("IdUsuarioPersonagem")]
        public virtual Usuario UsuarioPersonagem { get; set; }

        public int IdRacaPersonagem { get; set; }

        [ForeignKey("IdRacaPersonagem")]
        public virtual Raca RacaPersonagem { get; set; }

        public int IdSecretPersonagem { get; set; }

        [ForeignKey("IdSecretPersonagem")]
        public virtual Secret SecretPersonagem { get; set; }

        public int IdClassePersonagem { get; set; }

        [ForeignKey("IdClassePersonagem")]
        public virtual Classe ClassePersonagem { get; set; }

        public int IdActiveSkillPersonagem { get; set; }

        [ForeignKey("IdActiveSkillPersonagem")]
        public virtual ActiveSkill ActiveSkillPersonagem { get; set; }

        public int IdCubePersonagem { get; set; }

        [ForeignKey("IdCubePersonagem")]
        public virtual Cube CubePersonagem { get; set; }

        public string NomePersonagem { get; set; }

        public int LevelPersonagem { get; set; }

        public int ExpPersonagem { get; set; }

        public string ImagemPersonagem { get; set; }

        public string MarkPersonagem { get; set; }

        public int OspPersonagem { get; set; }

        public int SpPersonagem { get; set; }

        public string OrdemPersonagem { get; set; }

        public int HpPersonagem { get; set; }

        public int MpPersonagem { get; set; }
        
        public int DmgfPersonagem { get; set; }

        public int DmgmPersonagem { get; set; }

        public int DefPersonagem { get; set; }

        public int FurPersonagem { get; set; }

        public int DetPersonagem { get; set; }

        public int CritPersonagem { get; set; }

        public int AcrPersonagem { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (string.IsNullOrEmpty(NomePersonagem))
            {
                AddError("O campo Nome do Personagem não foi informado.");
            }

            if (LevelPersonagem <= 0)
            {
                AddError("O campo Level do Personagem não foi informado.");
            }

            if (string.IsNullOrEmpty(OrdemPersonagem))
            {
                AddError("O campo Ordem do Personagem não foi informado.");
            }

            if (HpPersonagem <= 0)
            {
                AddError("O campo HP da Personagem não foi informado.");
            }

            if (MpPersonagem <= 0)
            {
                AddError("O campo MP da Personagem não foi informado.");
            }

            if (DmgfPersonagem <= 0)
            {
                AddError("O campo DMGF da Personagem não foi informado.");
            }

            if (DmgmPersonagem <= 0)
            {
                AddError("O campo DMGM da Personagem não foi informado.");
            }

            if (FurPersonagem < 0)
            {
                AddError("O campo FUR da Personagem não foi informado.");
            }

            if (DetPersonagem < 0)
            {
                AddError("O campo DET da Personagem não foi informado.");
            }

            if (CritPersonagem < 0)
            {
                AddError("O campo CRIT da Personagem não foi informado.");
            }

            if (AcrPersonagem < 0)
            {
                AddError("O campo ACR da Personagem não foi informado.");
            }
        }
    }
}