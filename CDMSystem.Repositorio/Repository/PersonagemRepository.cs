using CDMSystem.Dominio.Contratos;
using CDMSystem.Dominio.Entidades;

namespace CDMSystem.Dominio.Repository
{
    public class PersonagemRepository : BaseRepository<Personagem>, IPersonagemRepository
    {
        public PersonagemRepository()
        {
            var newPersonagem = new Personagem();

            var personagemRepository = new PersonagemRepository();
            personagemRepository.Incluid(newPersonagem);
        }
    }
}