using Domain.Repository;
using Repository.Context;

namespace Repository.Repository
{
    public class GrupoRepository : BaseRepository<Domain.DTO.Grupo>, IGrupoRepository
    {
        public GrupoRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}