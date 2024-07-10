using ControleDeBar.Dominio._2._5_ModuloMesa;
using ControleDeBar.Infra.Orm._3._1._1_Compartilhado;

namespace ControleDeBar.Infra.Orm._3._1._6_ModuloMesa
{
    public class RepositorioMesaEmOrm(ControleDeBarDbContext dbContext) : IRepositorioMesa
    {
        public void Cadastrar(Mesa mesa)
        {
            dbContext.Mesas.Add(mesa);
            dbContext.SaveChanges();
        }
        public bool Editar(int id, Mesa mesaAtualizado)
        {
            Mesa mesa = dbContext.Mesas.Find(id)!;

            if (mesa == null) return false;

            mesa.AtualizarRegistro(mesaAtualizado);

            dbContext.Mesas.Update(mesa);
            dbContext.SaveChanges();

            return true;
        }
        public bool Excluir(int id)
        {
            Mesa mesa = dbContext.Mesas.Find(id)!;

            if (mesa == null) return false;

            dbContext.Mesas.Remove(mesa);
            dbContext.SaveChanges();

            return true;
        }

        public Mesa SelecionarPorId(int id) => dbContext.Mesas.Find(id)!;
        public List<Mesa> SelecionarTodos() => dbContext.Mesas.ToList();
    }
}
