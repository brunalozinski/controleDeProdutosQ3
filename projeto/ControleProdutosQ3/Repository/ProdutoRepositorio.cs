using ControleProdutosQ3.Data;
using ControleProdutosQ3.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleProdutosQ3.Repository
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ProdutoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public async Task<ProdutoModel> Adicionar(ProdutoModel produto)
        {
            await _bancoContext.Produto.AddAsync(produto);
            await _bancoContext.SaveChangesAsync();

            return produto;
        }

        public Task<bool> Apagar(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AtivarDesativar(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProdutoModel> Atualizar(ProdutoModel produto)
        {
            ProdutoModel produtoDB = await ListarPorId (produto.Id);

            if (produtoDB == null) throw new System.Exception("Erro na atualização do produto");

            produtoDB.Descricao = produto.Descricao;
            produtoDB.CodigoDeBarras = produto.CodigoDeBarras;
            produtoDB.DataDeValidade = produto.DataDeValidade;
            produtoDB.Quantidade = produto.Quantidade;
            produtoDB.Valor = produto.Valor;
            produtoDB.NomeDaFoto = produto.NomeDaFoto;
            produtoDB.Foto = produto.Foto;
            produtoDB.Ativo = produto.Ativo;

            _bancoContext.Update(produtoDB);
            await _bancoContext.SaveChangesAsync();
            return await Task.FromResult(produtoDB);
        }

        public async Task<List<ProdutoModel>> BuscaTodos()
        {
            return await _bancoContext.Produto.ToListAsync();
        }

        public async Task<ProdutoModel> ListarPorId(long id)
        {
            Task<ProdutoModel> produtoDB;
            try
            {
                produtoDB = _bancoContext.Produto.FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (System.Exception e)
            {
                throw new System.Exception($"{e.Message} Ocorreu erro na busca do produto");
            }
            return await produtoDB;
        }
    }
}
