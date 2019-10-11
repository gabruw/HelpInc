using Domain.DTO;

namespace Domain.Repository
{
    public interface IHabilidadeRepository : IBaseRepository<Habilidade>
    {
        Empresa GetbyLoginId(long LoginId);
    }
}