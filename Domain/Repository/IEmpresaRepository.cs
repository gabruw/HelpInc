using Domain.DTO;

namespace Domain.Repository
{
    public interface IEmpresaRepository : IBaseRepository<Empresa>
    {
        Empresa GetbyLoginId(long LoginId);
    }
}