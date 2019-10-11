using System.Linq;
using Domain.DTO;
using Domain.Repository;
using Repository.Context;

namespace Repository.Repository
{
    public class ConsumidorRepository : BaseRepository<Consumidor>, IConsumidorRepository
    {
        private readonly HelpIncContext Context;

        public ConsumidorRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {
            Context = helpIncContext;
        }

        public Consumidor GetbyLoginId(long LoginId)
        {
            return Context.Consumidor.Where(x => x.IdLogin == LoginId).FirstOrDefault();
        }
    }
}