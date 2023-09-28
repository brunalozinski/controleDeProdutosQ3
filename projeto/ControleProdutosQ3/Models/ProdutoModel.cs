using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ControleProdutosQ3.Models
{
    [Index(nameof(CodigoDeBarras),IsUnique = true)]
    public class ProdutoModel
    {
        public Int64 Id { get; set; }  //? - com o operador, não é obrigatório, pode ser nulo.

        [Required (ErrorMessage = "Campo obrigatório!")]      // [Required] - Obrigatório   
                                                              // control + . (importa biblioteca)
        [StringLength(12, MinimumLength = 12,
            ErrorMessage = "Mínimo de 12 caracteres!")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage ="Este campo aceita somente números")]     
        // @"^[0-9]+$" - só aceita expressão de 0 a 9 - limitando números e expressões
        public string CodigoDeBarras { get; set; }

        //[RegularExpression(@"^[A-Z] + [a-zA-Z\s]*$")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Descricao { get; set; }

        //[Range(typeof(DateTime),minimum: "23/09/2023", maximum: "24/09/2024")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]  // Formatação da data
        [DataType(DataType.Date)]
        public DateTime DataDeValidade { get; set; }

        [DataType(DataType.DateTime)]       // Toda vez que entrar um produto, ele vai marcar a data que entrou
        public DateTime DataDeRegistro { get; set; }

        [Range(1, 1000)]
        public int? Quantidade { get; set; }   //int? - ? deixa não obrigatório 

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [MaybeNull]                    //[MaybeNull] -  Não Obrigatório
        public string? NomeDaFoto { get; set; }

        [MaybeNull]
        public byte[]? Foto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public bool Ativo { get; set; }
        // atalho (prop + tab + tab) - public int MyProperty { get; set; }

    }
}
