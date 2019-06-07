namespace CDMSystem.Repositorio
{
    public class Cube
    {
        public Cube()
        {
            var newCube = new Dominio.DTO.Cube();

            var cubeRepository = new CubeRepository();
            cubeRepository.Incluid(newCube);
        }
    }
}