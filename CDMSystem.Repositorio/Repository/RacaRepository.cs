using CDMSystem.Dominio.Contratos;
using CDMSystem.Dominio.Repository;
using CDMSystem.Repositorio.Context;

namespace CDMSystem.Repositorio
{
    public class RacaRepository : BaseRepository<Dominio.DTO.Raca>, IRacaRepository
    {
        public RacaRepository(CDMSystemContext cdmSystemContext) : base(cdmSystemContext)
        {

        }
    }
}