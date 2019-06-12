using CDMSystem.Dominio.Contratos;
using CDMSystem.Dominio.Repository;
using CDMSystem.Repositorio.Context;

namespace CDMSystem.Repositorio
{
    public class OminiSkillRepository : BaseRepository<Dominio.DTO.OminiSkill>, IOminiSkillRepository
    {
        public OminiSkillRepository(CDMSystemContext cdmSystemContext) : base(cdmSystemContext)
        {

        }
    }
}