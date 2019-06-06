namespace CDMSystem.Repositorio
{
    public class Raca
    {
        public Raca()
        {
            var newRaca = new Dominio.DTO.Raca();

            var racaRepository = new RacaRepository();
            racaRepository.Incluid(newRaca);
        }
    }
}