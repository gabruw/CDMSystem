namespace CDMSystem.Dominio.Entidades
{
    public class Personagem : DTODefault
    {
        public int IdPersonagem { get; set; }

        public Raca IdRacaPersonagem { get; set; }

        public Secret IdSecretPersonagem { get; set; }

        public Classe IdClassePersonagem { get; set; }

        public ActiveSkill IdActiveSkillPersonagem { get; set; }

        public string NomePersonagem { get; set; }

        public int LevelPersonagem { get; set; }

        public string ImagemPersonagem { get; set; }

        public string MarkPersonagem { get; set; }

        public int OspPersonagem { get; set; }

        public int SpPersonagem { get; set; }

        public string OrdemPersonagem { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}