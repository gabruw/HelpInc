using Domain.Repository;
using Repository.Context;

namespace Repository.Repository
{
    public class PrestadorRepository : BaseRepository<Domain.DTO.Prestador>, IPrestadorRepository
    {
        public PrestadorRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}