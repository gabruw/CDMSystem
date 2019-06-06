namespace CDMSystem.Repositorio
{
    public class ActiveSkill
    {
        public ActiveSkill()
        {
            var newActiveSkill = new Dominio.DTO.ActiveSkill();

            var activeSkillRepository = new ActiveSkillRepository();
            activeSkillRepository.Incluid(newActiveSkill);
        }
    }
}