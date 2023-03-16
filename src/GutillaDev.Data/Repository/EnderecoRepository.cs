using GutillaDev.Business.Interfaces;
using GutillaDev.Business.Models;
using GutillaDev.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace GutillaDev.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
           return await Db.Enderecos.AsNoTracking().FirstOrDefaultAsync(e=>e.FornecedorId == fornecedorId);
        }
    }
}
