using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace ControleProdutosQ3.Models
{
    public class ClienteModel
    {
        [Required(ErrorMessage = "Campo obrigatório!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string? Telefone { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [StringLength(8, MinimumLength = 8,
            ErrorMessage = "Mínimo 8 caracteres!")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Este campo aceita somente números")]
        public string? Cep { get; set; }

        [MaybeNull]
        public Byte[] Foto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public int Status { get; set; }
    }
}
