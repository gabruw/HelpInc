using Domain.DTO;
using Domain.Repository;
using Repository.Context;

namespace Repository.Repository
{
    public class HabilidadeRepository : BaseRepository<Habilidade>, IHabilidadeRepository
    {
        public HabilidadeRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}