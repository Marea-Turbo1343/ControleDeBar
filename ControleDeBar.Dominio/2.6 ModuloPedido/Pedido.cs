using ControleDeBar.Dominio._2._1_Compartilhado;
using ControleDeBar.Dominio._2._4_ModuloGarcom;
using ControleDeBar.Dominio._2._7_ModuloProduto;


namespace ControleDeBar.Dominio._2._6_ModuloPedido
{
    public class Pedido() : EntidadeBase
    {
        public Garcom Garcom { get; set; }
        public Produto Produto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Valor { get; set; }

        public Pedido(Garcom garcom, Produto produto, decimal quantidade, decimal valor) : this()
        {
            Garcom = garcom;
            Produto = produto;
            Quantidade = quantidade;
            Valor = valor;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Pedido atualizado = (Pedido)novoRegistro;

            Garcom = atualizado.Garcom;
            Produto = atualizado.Produto;
            Quantidade = atualizado.Quantidade;
            Valor = atualizado.Valor;
        }
        public override List<string> Validar()
        {
            List<string> erros = [];

            VerificaNulo(ref erros, Garcom, "Garçom");
            VerificaNulo(ref erros, Produto, "Produto");
            VerificaNulo(ref erros, Quantidade, "Quantidade");

            return erros;
        }
        public override string ToString() => $"Pedido {Id}";
    }
}
