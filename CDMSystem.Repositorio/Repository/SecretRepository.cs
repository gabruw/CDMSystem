using CDMSystem.Dominio.Contratos;
using CDMSystem.Dominio.Repository;
using CDMSystem.Repositorio.Context;

namespace CDMSystem.Repositorio
{
    public class SecretRepository : BaseRepository<Dominio.DTO.Secret>, ISecretRepository
    {
        public SecretRepository(CDMSystemContext cdmSystemContext) : base(cdmSystemContext)
        {

        }
    }
}