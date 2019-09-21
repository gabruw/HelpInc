using Domain.Repository;
using Repository.Context;

namespace Repository.Repository
{
    public class EmpresaRepository : BaseRepository<Domain.DTO.Empresa>, IEmpresaRepository
    {
        public EmpresaRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}