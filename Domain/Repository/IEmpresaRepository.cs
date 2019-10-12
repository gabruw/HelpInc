using Domain.DTO;

namespace Domain.Repository
{
    public interface IEmpresaRepository : IBaseRepository<Empresa>
    {
        Empresa GetbyIdLogin(long IdLogin);
    }
}