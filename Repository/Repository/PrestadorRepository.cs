using Domain.DTO;
using Domain.Repository;
using Repository.Context;
using System.Linq;

namespace Repository.Repository
{
    public class PrestadorRepository : BaseRepository<Prestador>, IPrestadorRepository
    {
        private readonly HelpIncContext Context;

        public PrestadorRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {
            Context = helpIncContext;
        }

        public Prestador GetbyLoginId(long LoginId)
        {
            return Context.Prestador.Where(x => x.IdLogin == LoginId).FirstOrDefault();
        }
    }
}