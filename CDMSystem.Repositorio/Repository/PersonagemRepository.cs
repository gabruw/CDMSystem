using CDMSystem.Dominio.Contratos;
using CDMSystem.Dominio.Repository;

namespace CDMSystem.Repositorio
{
    public class PersonagemRepository : BaseRepository<Dominio.DTO.Personagem>, IPersonagemRepository
    {
        public PersonagemRepository()
        {
            
        }
    }
}