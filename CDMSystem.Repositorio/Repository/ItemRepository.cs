using CDMSystem.Dominio.Contratos;
using CDMSystem.Dominio.Repository;

namespace CDMSystem.Repositorio.Repository
{
    public class ItemRepository : BaseRepository<Dominio.DTO.Item>, IItemRepository
    {
        public ItemRepository()
        {

        }
    }
}