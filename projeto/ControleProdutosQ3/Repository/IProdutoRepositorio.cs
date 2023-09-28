using ControleProdutosQ3.Models;
using System.Runtime.CompilerServices;

namespace ControleProdutosQ3.Repository
{
    public interface IProdutoRepositorio
    {
        Task<List<ProdutoModel>> BuscaTodos();
        Task<ProdutoModel> Adicionar(ProdutoModel produto);
        Task<ProdutoModel> ListarPorId(long id);
        Task<ProdutoModel> Atualizar (ProdutoModel produto);
        Task<bool> AtivarDesativar (long id);
        Task<bool> Apagar (long id);
    }
}
