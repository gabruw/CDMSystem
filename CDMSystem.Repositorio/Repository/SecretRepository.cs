using CDMSystem.Dominio.Contratos;
using CDMSystem.Dominio.Repository;

namespace CDMSystem.Repositorio
{
    public class SecretRepository : BaseRepository<Dominio.DTO.Secret>, ISecretRepository
    {
        public SecretRepository()
        {

        }
    }
}