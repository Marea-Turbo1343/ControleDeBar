namespace ControleDeBar.Dominio._2._4_ModuloGarcom
{
    public interface IRepositorioGarcom
    {
        void Cadastrar(Garcom garcom);
        bool Editar(int id, Garcom garcom);
        bool Excluir(int id);
        Garcom SelecionarPorId(int id);
        List<Garcom> SelecionarTodos();
    }
}
