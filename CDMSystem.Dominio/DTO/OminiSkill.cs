using System.Collections.Generic;

namespace CDMSystem.Dominio.DTO
{
    public class OminiSkill : DTODefault
    {
        public OminiSkill()
        {

        }

        public int IdOminiSkill { get; set; }

        public int IdClasseOminiSkill { get; set; }

        public virtual Classe ClasseOminiSkill { get; set; }

        public int IdSecretOminiSkill { get; set; }

        public virtual Secret SecretOminiSkill { get; set; }

        public int IdItemOminiSkill { get; set; }

        public virtual Item ItemOminiSkill { get; set; }

        public string NomeOminiSkill { get; set; }

        public string TipoOminiSkill { get; set; }

        public string ElementoOminiSkill { get; set; }

        public string DescricaoOminiSkill { get; set; }

        public string EfeitoOminiSkill { get; set; }

        public string CustoOminiSkill { get; set; }

        public string AreaOminiSkill { get; set; }

        public int LevelOminiSkill { get; set; }

        public string UsoOminiSkill { get; set; }

        public virtual ICollection<string> PreRequisitoOminiSkill { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (string.IsNullOrEmpty(NomeOminiSkill))
            {
                AddError("O campo Nome da Omini Skill não foi informado.");
            }

            if (string.IsNullOrEmpty(TipoOminiSkill))
            {
                AddError("O campo Tipo da Omini Skill não foi informado.");
            }

            if (string.IsNullOrEmpty(DescricaoOminiSkill))
            {
                AddError("O campo Descrição da Omini Skill não foi informado.");
            }

            if (string.IsNullOrEmpty(EfeitoOminiSkill))
            {
                AddError("O campo Efeito da Omini Skill não foi informado.");
            }

            if (string.IsNullOrEmpty(CustoOminiSkill))
            {
                AddError("O campo Custo da Omini Skill não foi informado.");
            }

            if (string.IsNullOrEmpty(AreaOminiSkill))
            {
                AddError("O campo Área da Omini Skill não foi informado.");
            }

            if (LevelOminiSkill < 0)
            {
                AddError("O campo Level da Omini Skill não foi informado.");
            }

            if (string.IsNullOrEmpty(UsoOminiSkill))
            {
                AddError("O campo Uso da Omini Skill não foi informado.");
            }
        }
    }
}