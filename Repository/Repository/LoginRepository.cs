using Domain.Repository;
using Repository.Context;
using System.Linq;

namespace Repository.Repository
{
    public class LoginRepository : BaseRepository<Domain.DTO.Login>, ILoginRepository
    {
        protected readonly HelpIncContext Context;

        public LoginRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {
            Context = helpIncContext;
        }

        public Domain.DTO.Login Logar(Domain.DTO.Login dtLogin)
        {
            try
            {
                var entity = Context.Login.Where(x => x.Email == dtLogin.Email);
                var firstEntity = entity.First();

                if (firstEntity.Senha == dtLogin.Senha)
                {
                    dtLogin.Id = firstEntity.Id;
                    dtLogin.Tipo = firstEntity.Tipo;
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