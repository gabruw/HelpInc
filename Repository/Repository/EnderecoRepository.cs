using Domain.DTO;
using Domain.Repository;
using Repository.Context;
using System.Linq;

namespace Repository.Repository
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        private readonly HelpIncContext Context;

        public EnderecoRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {
            Context = helpIncContext;
        }

        public Endereco GetbyIdEndereco(long EnderecoId)
        {
            return Context.Endereco.Where(x => x.Id == EnderecoId).FirstOrDefault();
        }
    }
}