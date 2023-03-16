using GutillaDev.Business.Models;

namespace GutillaDev.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId); //obter um endereco do fornecedor
    }
}
