using Domain.Repository;
using Repository.Context;
using System.Linq;

namespace Repository.Repository
{
    public class LoginRepository : BaseRepository<Domain.DTO.Login>, ILoginRepository
    {
        protected readonly HelpIncContext HIContext;

        public LoginRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {
            HIContext = helpIncContext;
        }

        public Domain.DTO.Login Logar(Domain.DTO.Login dtLogin)
        {
            try
            {
                var conta = HIContext.Login.Where(x => x.Email == dtLogin.Email);

                return dtLogin;
            }
            catch
            {
                return dtLogin;
            }
        }
    }
}