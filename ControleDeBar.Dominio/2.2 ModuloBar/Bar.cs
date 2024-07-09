using ControleDeBar.Dominio._2._1_Compartilhado;
using ControleDeBar.Dominio._2._4_ModuloGarcom;
using ControleDeBar.Dominio._2._5_ModuloMesa;
using ControleDeBar.Dominio._2._7_ModuloProduto;

namespace ControleDeBar.Dominio
{
    public class Bar : EntidadeBase
    {
        public string Nome { get; set; }
        public decimal Faturamento { get; set; }
        public Mesa Mesa { get; set; }
        public Garcom Garcom { get; set; }
        public Produto Produto { get; set; }

        public Bar()
        {

        }

        public Bar(string nome, decimal faturamento, Mesa mesa, Garcom garcom, Produto produto)
        {
            Nome = nome;
            Faturamento = faturamento;
            Mesa = mesa;
            Garcom = garcom;
            Produto = produto;
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