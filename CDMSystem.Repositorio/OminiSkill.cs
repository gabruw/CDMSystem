namespace CDMSystem.Repositorio
{
    public class OminiSkill
    {
        public OminiSkill()
        {
            var newOminiSkill = new Dominio.DTO.OminiSkill();

            var ominiSkillRepository = new OminiSkillRepository();
            ominiSkillRepository.Incluid(newOminiSkill);
        }
    }
}