using Domain.Repository;
using Repository.Context;

namespace Repository.Repository
{
    public class LoginRepository : BaseRepository<Domain.DTO.Login>, ILoginRepository
    {
        public LoginRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}