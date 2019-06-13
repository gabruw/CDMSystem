using CDMSystem.Dominio.Contratos;
using CDMSystem.Dominio.Repository;
using CDMSystem.Repositorio.Context;

namespace CDMSystem.Repositorio
{
    public class UsuarioRepository : BaseRepository<Dominio.DTO.Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(CDMSystemContext cdmSystemContext) : base(cdmSystemContext)
        {

        }
    }
}