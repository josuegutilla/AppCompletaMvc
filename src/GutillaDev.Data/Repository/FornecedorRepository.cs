using GutillaDev.Business.Intefaces;
using GutillaDev.Business.Models;
using GutillaDev.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace GutillaDev.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(MeuDbContext context) : base(context) { }

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking().Include(e => e.Endereco).FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking().Include(p => p.Produtos).Include(e => e.Endereco).FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}
