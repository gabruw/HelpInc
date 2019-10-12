using Domain.DTO;

namespace Domain.Repository
{
    public interface IPrestadorRepository : IBaseRepository<Prestador>
    {
        Prestador GetbyIdLogin(long IdLogin);
    }
}