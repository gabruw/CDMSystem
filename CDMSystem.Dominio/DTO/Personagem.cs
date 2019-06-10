namespace CDMSystem.Dominio.DTO
{
    public class Personagem : DTODefault
    {
        public Personagem()
        {

        }

        public int IdPersonagem { get; set; }

        public string IdRacaPersonagem { get; set; }

        public virtual Raca RacaPersonagem { get; set; }

        public string IdSecretPersonagem { get; set; }

        public virtual Secret SecretPersonagem { get; set; }

        public string IdClassePersonagem { get; set; }

        public virtual Classe ClassePersonagem { get; set; }

        public string IdActiveSkillPersonagem { get; set; }

        public virtual ActiveSkill ActiveSkillPersonagem { get; set; }

        public string IdCubePersonagem { get; set; }

        public virtual Cube CubePersonagem { get; set; }

        public string NomePersonagem { get; set; }

        public int LevelPersonagem { get; set; }

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

        public virtual Core ElmoPersonagem { get; set; }

        public virtual Core PeitoralPersonagem { get; set; }

        public virtual Core BracoDireitoPersonagem { get; set; }

        public virtual Core BracoEsquerdoPersonagem { get; set; }

        public virtual Core CalcaPersonagem { get; set; }

        public virtual Core BotaPersonagem { get; set; }

        public virtual Core ArmaPrimariaPersonagem { get; set; }

        public virtual Core ArmaSecundariaPersonagem { get; set; }

        public virtual Core PendantePersonagem { get; set; }

        public virtual Core AnelDireitoPersonagem { get; set; }

        public virtual Core AnelEsquerdoPersonagem { get; set; }

        public virtual Core AsaPersonagem { get; set; }

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