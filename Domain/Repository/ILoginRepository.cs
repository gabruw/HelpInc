using Domain.DTO;

namespace Domain.Repository
{
    public interface ILoginRepository : IBaseRepository<Login>
    {
        Login Logar(Login dtLogin);
    }
}