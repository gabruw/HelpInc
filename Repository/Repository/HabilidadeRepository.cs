using Domain.Repository;
using Repository.Context;

namespace Repository.Repository
{
    public class HabilidadeRepository : BaseRepository<Domain.DTO.Habilidade>, IHabilidadeRepository
    {
        public HabilidadeRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}