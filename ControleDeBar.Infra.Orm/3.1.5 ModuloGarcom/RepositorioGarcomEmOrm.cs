using ControleDeBar.Dominio._2._4_ModuloGarcom;
using ControleDeBar.Infra.Orm._3._1._1_Compartilhado;


namespace ControleDeBar.Infra.Orm._3._1._5_ModuloGarcom
{
    public class RepositorioGarcomEmOrm(ControleDeBarDbContext dbContext) : IRepositorioGarcom
    {
        public void Cadastrar(Garcom garcom)
        {
            dbContext.Garcons.Add(garcom);
            dbContext.SaveChanges();
        }

        public bool Editar(int id, Garcom garcomAtualizada)
        {
            Garcom garcom = dbContext.Garcons.Find(id)!;

            if (garcom == null)
                return false;

            garcom.AtualizarRegistro(garcomAtualizada);

            dbContext.Garcons.Update(garcom);
            dbContext.SaveChanges();

            return true;
        }

        public bool Excluir(int id)
        {
            Garcom garcom = dbContext.Garcons.Find(id)!;

            if (garcom == null)
                return false;

            dbContext.Garcons.Remove(garcom);
            dbContext.SaveChanges();

            return true;
        }

        public Garcom SelecionarPorId(int id) => dbContext.Garcons.Find(id)!;
        public List<Garcom> SelecionarTodos() => [.. dbContext.Garcons];
    }
}
