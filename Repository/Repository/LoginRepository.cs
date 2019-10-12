using Domain.DTO;
using Domain.Repository;
using Repository.Context;
using System.Linq;

namespace Repository.Repository
{
    public class LoginRepository : BaseRepository<Login>, ILoginRepository
    {
        protected readonly HelpIncContext Context;

        public LoginRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {
            Context = helpIncContext;
        }

        public Login Logar(Login dtLogin)
        {
            try
            {
                var entity = Context.Login.Where(x => x.Email == dtLogin.Email).FirstOrDefault();

                if (entity.Senha == dtLogin.Senha)
                {
                    dtLogin.Id = entity.Id;
                    dtLogin.Tipo = entity.Tipo;
                }

                return dtLogin;
            }
            catch
            {
                return dtLogin;
            }
        }
    }
}