using GutillaDev.Business.Enums;
using GutillaDev.Business.Models;
using System.ComponentModel.DataAnnotations;

namespace GutillaDev.App.ViewModels
{
    public class FornecedorViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres!", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres!", MinimumLength = 11)]
        public string Documento { get; set; }

        [Display(Name = "Tipo")]
        public int TipoFornecedor { get; set; } //enumeração;

        public EnderecoViewModel Endereco { get; set; } //composição tem 1;

        [Display(Name = "Ativo?")]
        public bool Ativo { get; set; }

        public IEnumerable<ProdutoViewModel> Produtos { get; set; } //composição tem vários;
    }
}
