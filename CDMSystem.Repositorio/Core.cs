namespace CDMSystem.Repositorio
{
    public class Core
    {
        public Core()
        {
            var newCore = new Dominio.DTO.Core();

            var coreRepository = new Repository.CoreRepository();
            coreRepository.Incluid(newCore);
        }
    }
}