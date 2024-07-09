using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.Dominio._2._6_ModuloPedido
{
    public interface IRepositorioPedido
    {
        void Cadastrar(Pedido pedido);
        bool Editar(int id, Pedido pedido);
        bool Excluir(int id);
        Pedido SelecionarPorId(int id);
        List<Pedido> SelecionarTodos();
    }
}
