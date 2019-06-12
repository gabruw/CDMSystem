using CDMSystem.Dominio.Contratos;
using CDMSystem.Dominio.Repository;
using CDMSystem.Repositorio.Context;

namespace CDMSystem.Repositorio.Repository
{
    public class CubeRepository : BaseRepository<Dominio.DTO.Cube>, ICubeRepository
    {
        public CubeRepository(CDMSystemContext cdmSystemContext) : base(cdmSystemContext)
        {

        }
    }
}