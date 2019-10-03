using Domain.Repository;
using Repository.Context;

namespace Repository.Repository
{
    public class MensagemRepository : BaseRepository<Domain.DTO.Mensagem>, IMensagemRepository
    {
        public MensagemRepository(HelpIncContext helpIncContext) : base(helpIncContext)
        {

        }
    }
}