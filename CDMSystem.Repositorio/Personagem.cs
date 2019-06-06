namespace CDMSystem.Repositorio
{
    public class Personagem
    {
        public Personagem()
        {
            var newPersonagem = new Dominio.DTO.Personagem();

            var personagemRepository = new PersonagemRepository();
            personagemRepository.Incluid(newPersonagem);
        }
    }
}