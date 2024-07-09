using ControleDeBar.Dominio._2._7_ModuloProduto;
using ControleDeBar.Infra.Orm._3._1._1_Compartilhado;

namespace ControleDeBar.Infra.Orm._3._1._8_ModuloProduto
{
    public class RepositorioProdutoEmOrm(ControleDeBarDbContext dbContext) : IRepositorioProduto
    {
        public void Cadastrar(Produto produto)
        {
            dbContext.Produtos.Add(produto);
            dbContext.SaveChanges();
        }
        public bool Editar(int id, Produto produtoAtualizado)
        {
            Produto produto = dbContext.Produtos.Find(id)!;

            if (produto == null) return false;

            produto.AtualizarRegistro(produtoAtualizado);

            dbContext.Produtos.Update(produto);
            dbContext.SaveChanges();

            return true;
        }
        public bool Excluir(int id)
        {
            Produto produto = dbContext.Produtos.Find(id)!;

            if (produto == null) return false;

            dbContext.Produtos.Remove(produto);
            dbContext.SaveChanges();

            return true;
        }

        public Produto SelecionarPorId(int id) => dbContext.Produtos.Find(id)!;
        public List<Produto> SelecionarTodos() => [.. dbContext.Produtos];
    }
}
