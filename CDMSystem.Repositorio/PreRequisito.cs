namespace CDMSystem.Repositorio
{
    public class PreRequisito
    {
        public PreRequisito()
        {
            var newPreRequisito = new Dominio.DTO.PreRequisito();

            var preRequisitoRepository = new PreRequisitoRepository();
            preRequisitoRepository.Incluid(newPreRequisito);
        }
    }
}