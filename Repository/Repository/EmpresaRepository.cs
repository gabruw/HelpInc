using Domain.DTO;
using Domain.Repository;
using Repository.Context;
using System.Linq;

namespace Repository.Repository
{
    public class EmpresaRepository : BaseRepository<Empresa>, IEmpresaRepository
    {
        private readonly HelpIncContext Context;

        public EmpresaRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {
            Context = helpIncContext;
        }

        public Empresa GetbyLoginId(long LoginId)
        {
            return Context.Empresa.Where(x => x.IdLogin == LoginId).FirstOrDefault();
        }
    }
}