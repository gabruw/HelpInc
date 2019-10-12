using Domain.DTO;
using Domain.Repository;
using Repository.Context;

namespace Repository.Repository
{
    public class MensagemRepository : BaseRepository<Mensagem>, IMensagemRepository
    {
        public MensagemRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}