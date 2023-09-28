using ControleProdutosQ3.Models;

namespace ControleProdutosQ3.Repository
{
    public interface IClienteRepositorio
    {
        Task<List<ClienteModel>> BuscaTodos();
        Task<ClienteModel> Adicionar(ClienteModel cliente);
    }
}
