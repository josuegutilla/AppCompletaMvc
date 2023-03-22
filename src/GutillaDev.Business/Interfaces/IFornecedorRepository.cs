using GutillaDev.Business.Interfaces;
using GutillaDev.Business.Models;

namespace GutillaDev.Business.Intefaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);
    }
}