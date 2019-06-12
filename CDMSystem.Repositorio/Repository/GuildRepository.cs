using CDMSystem.Dominio.Contratos;
using CDMSystem.Dominio.Repository;
using CDMSystem.Repositorio.Context;

namespace CDMSystem.Repositorio
{
    public class GuildRepository : BaseRepository<Dominio.DTO.Guild>, IGuildRepository
    {
        public GuildRepository(CDMSystemContext cdmSystemContext) : base(cdmSystemContext)
        {

        }
    }
}