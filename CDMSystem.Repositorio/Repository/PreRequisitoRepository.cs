using CDMSystem.Dominio.Contratos;
using CDMSystem.Dominio.Repository;
using CDMSystem.Repositorio.Context;

namespace CDMSystem.Repositorio
{
    public class PreRequisitoRepository : BaseRepository<Dominio.DTO.PreRequisito>, IPreRequisitoRepository
    {
        public PreRequisitoRepository(CDMSystemContext cdmSystemContext) : base(cdmSystemContext)
        {

        }
    }
}