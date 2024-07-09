using ControleDeBar.Dominio._2._1_Compartilhado;
using ControleDeBar.Dominio._2._6_ModuloPedido;

namespace ControleDeBar.Dominio._2._3_ModuloConta
{
    public class Conta : EntidadeBase
    {
        public Pedido Pedido { get; set; }
        public decimal ValorTotal { get; set; }
        public bool EmAberto { get; set; }
        public DateTime Data { get; set; }

        public Conta()
        {

        }

        public Conta(Pedido pedido, decimal valorTotal, bool emAberto, DateTime data)
        {
            Pedido = pedido;
            ValorTotal = valorTotal;
            EmAberto = emAberto;
            Data = data;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            throw new NotImplementedException();
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
