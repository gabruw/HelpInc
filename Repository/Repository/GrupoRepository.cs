using Domain.DTO;
using Domain.Repository;
using Repository.Context;

namespace Repository.Repository
{
    public class GrupoRepository : BaseRepository<Grupo>, IGrupoRepository
    {
        public GrupoRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}