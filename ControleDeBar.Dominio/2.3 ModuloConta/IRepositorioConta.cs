using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.Dominio._2._3_ModuloConta
{
    public interface IRepositorioConta
    {
        void Cadastrar(Conta conta);
        bool Editar(int id, Conta conta);
        bool Excluir(int id);
        Conta SelecionarPorId(int id);
        List<Conta> SelecionarTodos();
    }
}
