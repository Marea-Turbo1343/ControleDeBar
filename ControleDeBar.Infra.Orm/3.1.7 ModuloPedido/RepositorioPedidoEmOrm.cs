using ControleDeBar.Dominio._2._6_ModuloPedido;
using ControleDeBar.Infra.Orm._3._1._1_Compartilhado;

namespace ControleDeBar.Infra.Orm._3._1._7_ModuloPedido
{
    public class RepositorioPedidoEmOrm(ControleDeBarDbContext dbContext) : IRepositorioPedido
    {
        public void Cadastrar(Pedido pedido)
        {
            dbContext.Pedidos.Add(pedido);
            dbContext.SaveChanges();
        }
        public bool Editar(int id, Pedido pedidoAtualizado)
        {
            Pedido pedido = dbContext.Pedidos.Find(id)!;

            if (pedido == null) return false;

            pedido.AtualizarRegistro(pedidoAtualizado);

            dbContext.Pedidos.Update(pedido);
            dbContext.SaveChanges();

            return true;
        }
        public bool Excluir(int id)
        {
            Pedido pedido = dbContext.Pedidos.Find(id)!;

            if (pedido == null) return false;

            dbContext.Pedidos.Remove(pedido);
            dbContext.SaveChanges();

            return true;
        }

        public Pedido SelecionarPorId(int id) => dbContext.Pedidos.Find(id)!;
        public List<Pedido> SelecionarTodos() => [.. dbContext.Pedidos];
    }
}
