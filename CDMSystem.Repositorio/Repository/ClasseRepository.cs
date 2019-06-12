using CDMSystem.Dominio.Contratos;
using CDMSystem.Dominio.Repository;
using CDMSystem.Repositorio.Context;

namespace CDMSystem.Repositorio
{
    public class ClasseRepository : BaseRepository<Dominio.DTO.Classe>, IClasseRepository
    {
        public ClasseRepository(CDMSystemContext cdmSystemContext) : base(cdmSystemContext)
        {

        }
    }
}