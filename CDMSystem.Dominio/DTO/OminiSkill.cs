namespace CDMSystem.Dominio.Entidades
{
    public class OminiSkill : DTODefault
    {
        public int IdOminiSkill { get; set; }

        public string NomeOminiSkill { get; set; }

        public string TipoOminiSkill { get; set; }

        public string ElementoOminiSkill { get; set; }

        public string DescricaoOminiSkill { get; set; }

        public string EfeitoOminiSkill { get; set; }

        public string CustoOminiSkill { get; set; }

        public string AreaOminiSkill { get; set; }

        public int LevelOminiSkill { get; set; }

        public string UsoOminiSkill { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}