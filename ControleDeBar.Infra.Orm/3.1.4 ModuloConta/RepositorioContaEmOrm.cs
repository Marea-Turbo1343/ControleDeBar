using ControleDeBar.Dominio._2._3_ModuloConta;
using ControleDeBar.Infra.Orm._3._1._1_Compartilhado;

namespace ControleDeBar.Infra.Orm._3._1._4_ModuloConta
{
    public class RepositorioContaEmOrm(ControleDeBarDbContext dbContext) : IRepositorioConta
    {
        public void Cadastrar(Conta conta)
        {
            dbContext.Contas.Add(conta);
            dbContext.SaveChanges();
        }
        public bool Editar(int id, Conta contaAtualizada)
        {
            Conta conta = dbContext.Contas.Find(id)!;

            if (conta == null) return false;

            conta.AtualizarRegistro(contaAtualizada);

            dbContext.Contas.Update(conta);
            dbContext.SaveChanges();

            return true;
        }
        public bool Excluir(int id)
        {
            Conta conta = dbContext.Contas.Find(id)!;

            if (conta == null)
                return false;

            dbContext.Contas.Remove(conta);
            dbContext.SaveChanges();

            return true;
        }

        public Conta SelecionarPorId(int id) => dbContext.Contas.Include(c => c.Pedidos).FirstOrDefault(c => c.Id == id);
        public List<Conta> SelecionarTodos() => [.. dbContext.Contas.Include(c => c.Mesa).Include(c => c.Garcom)];
    }
}
