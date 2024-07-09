using ControleDeBar.Dominio._2._6_ModuloPedido;
using ControleDeBar.WinApp._1._1_Compartilhado.Extensions;

namespace ControleDeBar.WinApp._1._4_ModuloPedido
{
    public partial class TabelaPedidoControl : UserControl
    {
        public TabelaPedidoControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Pedido> pedidos)
        {
            grid.Rows.Clear();

            foreach (Pedido p in pedidos)
                grid.Rows.Add(p.Id, p.Garcom, p.Produto, p.Quantidade, p.Valor);
        }

        public int ObterRegistroSelecionado() => grid.SelecionarId();
        private DataGridViewColumn[] ObterColunas() =>
        [
            new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Garcom", HeaderText = "Garçom" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Produto", HeaderText = "Produto" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Quantidade", HeaderText = "Quantidade" },
            new DataGridViewTextBoxColumn { DataPropertyName = "ValorTotal", HeaderText = "Valor total" }
        ];
    }
}
