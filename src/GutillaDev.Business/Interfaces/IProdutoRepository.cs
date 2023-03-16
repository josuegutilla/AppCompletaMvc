using GutillaDev.Business.Models;

namespace GutillaDev.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId); //obter uma lista de produto por fornecedor
        Task<IEnumerable<Produto>> ObterProdutosFornecedores(); //obter uma lista de produtos e todos os fornecedores do produto
        Task<Produto> ObterProdutoFornecedor(Guid id); //obter um produto e o fornecdor do produto
    }
}
