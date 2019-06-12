using CDMSystem.Dominio.Contratos;
using CDMSystem.Dominio.Repository;
using CDMSystem.Repositorio.Context;

namespace CDMSystem.Repositorio.Repository
{
    public class ItemRepository : BaseRepository<Dominio.DTO.Item>, IItemRepository
    {
        public ItemRepository(CDMSystemContext cdmSystemContext) : base(cdmSystemContext)
        {

        }
    }
}