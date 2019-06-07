namespace CDMSystem.Dominio.DTO
{
    public class ActiveSkill : DTODefault
    {
        public int IdActiveSkill { get; set; }

        public string NomeActiveSkill { get; set; }

        public string DescricaoActiveSkill { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (string.IsNullOrEmpty(NomeActiveSkill))
            {
                AddError("O campo Nome da Active Skill não foi informado.");
            }

            if (string.IsNullOrEmpty(DescricaoActiveSkill))
            {
                AddError("O campo Descrição da Active Skill não foi informado.");
            }
        }
    }
}