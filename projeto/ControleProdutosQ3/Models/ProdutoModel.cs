using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ControleProdutosQ3.Models
{
    public class ProdutoModel
    {
        public Int64 Id { get; set; }  //? - com o operador, não é obrigatório, pode ser nulo.
        [Required]                     // [Required] - Obrigatório
        public string codigoDeBarras { get; set; }
        [Required]
        public string Descricao { get; set; }
        public DateTime DataDeValidade { get; set; }
        public DateTime DataDeRegistro { get; set; }
        public int Quantidade { get; set; }
        public decimal? Valor { get; set; }
        [MaybeNull]                    //[MaybeNull] -  Não Obrigatório
        public string NomeDaFoto { get; set; }
        [MaybeNull]
        public byte[] Foto { get; set; }
        public bool Ativo { get; set; }

    }
}
