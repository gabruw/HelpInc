using Domain.DTO;

namespace Domain.Repository
{
    public interface IPrestadorRepository : IBaseRepository<Prestador>
    {
        Prestador GetbyLoginId(long LoginId);
    }
}