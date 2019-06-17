using CDMSystem.Dominio.Contratos;
using CDMSystem.Dominio.Repository;
using CDMSystem.Repositorio.Context;

namespace CDMSystem.Repositorio
{
    public class RaceSkillRepository : BaseRepository<Dominio.DTO.RaceSkill>, IRaceSkillRepository
    {
        public RaceSkillRepository(CDMSystemContext cdmSystemContext) : base(cdmSystemContext)
        {

        }
    }
}