namespace CDMSystem.Dominio.Entidades
{
    public class ActiveSkill : DTODefault
    {
        public int IdActiveSkill { get; set; }

        public string NomeActiveSkill { get; set; }

        public string DescricaoActiveSkill { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}