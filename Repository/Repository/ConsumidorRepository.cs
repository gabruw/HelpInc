using Domain.Repository;
using Repository.Context;

namespace Repository.Repository
{
    public class ConsumidorRepository : BaseRepository<Domain.DTO.Consumidor>, IConsumidorRepository
    {
        public ConsumidorRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}