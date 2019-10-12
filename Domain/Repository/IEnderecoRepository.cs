using Domain.DTO;

namespace Domain.Repository
{
    public interface IEnderecoRepository : IBaseRepository<Endereco>
    {
        Endereco GetbyIdEndereco(long IdEndereco);
    }
}