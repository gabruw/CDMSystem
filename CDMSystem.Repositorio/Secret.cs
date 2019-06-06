namespace CDMSystem.Repositorio
{
    public class Secret
    {
        public Secret()
        {
            var newSecret = new Dominio.DTO.Secret();

            var secretRepository = new SecretRepository();
            secretRepository.Incluid(newSecret);
        }
    }
}