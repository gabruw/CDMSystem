namespace CDMSystem.Repositorio
{
    public class Classe
    {
        public Classe()
        {
            var newClasse = new Dominio.DTO.Classe();

            var classeRepository = new ClasseRepository();
            classeRepository.Incluid(newClasse);
        }
    }
}