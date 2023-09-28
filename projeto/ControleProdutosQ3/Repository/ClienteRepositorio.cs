using ControleProdutosQ3.Data;
using ControleProdutosQ3.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleProdutosQ3.Repository
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ClienteRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public async Task<ClienteModel> Adicionar(ClienteModel cliente)
        {
            await _bancoContext.Cliente.AddAsync(cliente);
            await _bancoContext.SaveChangesAsync();

            return cliente;
        }

        public async Task<List<ClienteModel>> BuscaTodos()
        {
            return await _bancoContext.Cliente.ToListAsync();
        }
    }
}
