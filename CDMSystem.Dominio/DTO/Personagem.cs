namespace CDMSystem.Dominio.DTO
{
    public class Personagem : DTODefault
    {
        public int IdPersonagem { get; set; }

        public Raca IdRacaPersonagem { get; set; }

        public Secret IdSecretPersonagem { get; set; }

        public Classe IdClassePersonagem { get; set; }

        public ActiveSkill IdActiveSkillPersonagem { get; set; }

        public Cube IdCubePersonagem { get; set; }

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

        public Core ElmoPersonagem { get; set; }

        public Core PeitoralPersonagem { get; set; }

        public Core BracoDireitoPersonagem { get; set; }

        public Core BracoEsquerdoPersonagem { get; set; }

        public Core CalcaPersonagem { get; set; }

        public Core BotaPersonagem { get; set; }

        public Core ArmaPrimariaPersonagem { get; set; }

        public Core ArmaSecundariaPersonagem { get; set; }

        public Core PendantePersonagem { get; set; }

        public Core AnelDireitoPersonagem { get; set; }

        public Core AnelEsquerdoPersonagem { get; set; }

        public Core AsaPersonagem { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}