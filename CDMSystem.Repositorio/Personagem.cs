using CDMSystem.Dominio.Repository;

namespace CDMSystem.Repositorio
{
    public class Personagem
    {
        public Personagem()
        {
            var newPersonagem = new Dominio.Entidades.Personagem();

            var personagemRepository = new PersonagemRepository();
            personagemRepository.Incluid(newPersonagem);
        }
    }
}