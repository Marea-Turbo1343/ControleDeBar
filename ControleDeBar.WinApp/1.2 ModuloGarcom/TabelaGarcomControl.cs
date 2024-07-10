using ControleDeBar.Dominio._2._4_ModuloGarcom;
using ControleDeBar.WinApp._1._1_Compartilhado.Extensions;


namespace ControleDeBar.WinApp._1._2_ModuloGarcom
{
    public partial class TabelaGarcomControl : UserControl
    {
        public TabelaGarcomControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Garcom> garcons)
        {
            grid.Rows.Clear();

            foreach (Garcom g in garcons)
                grid.Rows.Add(g.Id, g);
        }

        public int ObterRegistroSelecionado() => grid.SelecionarId();
        private DataGridViewColumn[] ObterColunas() =>
        [
            new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" }
        ];
    }
}