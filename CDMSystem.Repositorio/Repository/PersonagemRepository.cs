using CDMSystem.Dominio.Contratos;
using CDMSystem.Dominio.Repository;
using CDMSystem.Repositorio.Context;

namespace CDMSystem.Repositorio
{
    public class PersonagemRepository : BaseRepository<Dominio.DTO.Personagem>, IPersonagemRepository
    {
        public PersonagemRepository(CDMSystemContext cdmSystemContext) : base(cdmSystemContext)
        {

        }
    }
}