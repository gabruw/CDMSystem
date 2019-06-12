using CDMSystem.Dominio.Contratos;
using CDMSystem.Dominio.Repository;
using CDMSystem.Repositorio.Context;

namespace CDMSystem.Repositorio
{
    public class ActiveSkillRepository : BaseRepository<Dominio.DTO.ActiveSkill>, IActiveSkillRepository
    {
        public ActiveSkillRepository(CDMSystemContext cdmSystemContext) : base(cdmSystemContext)
        {

        }
    }
}