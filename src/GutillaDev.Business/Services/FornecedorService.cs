using GutillaDev.Business.Interfaces;
using GutillaDev.Business.Models;
using GutillaDev.Business.Models.Validations;
using GutillaDev.Business.Models.Validations.Documentos;

namespace GutillaDev.Business.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        public async Task Adicionar(Fornecedor fornecedor)
        {
            //validar o estado da entidade!
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)
                && !ExecutarValidacao(new EnderecoValidation(), fornecedor.Endereco)) return;
        }

        public async Task Atualizar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)) return;
        }

        public async Task AtualizarEndereco(Endereco endereco)
        {
            if (!ExecutarValidacao(new EnderecoValidation(), endereco)) return;
        }

        public async Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
