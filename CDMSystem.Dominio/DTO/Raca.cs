namespace CDMSystem.Dominio.Entidades
{
    public class Raca : DTODefault
    {
        public int IdRaca { get; set; }

        public string NomeRaca { get; set; }

        public string BonusRaca { get; set; }

        public string RaceSkillRaca { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}