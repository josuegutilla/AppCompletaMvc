using GutillaDev.Business.Models;

namespace GutillaDev.Business.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id); //obter o fornecedor é o endereço dele
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id); //obter o fornecedor os produtos e o endereço dele
    }
}
