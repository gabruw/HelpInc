using Domain.DTO;

namespace Domain.Repository
{
    public interface IConsumidorRepository : IBaseRepository<Consumidor>
    {
        Consumidor GetbyLoginId(long LoginId);
    }
}