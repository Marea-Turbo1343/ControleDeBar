using ControleDeBar.Dominio._2._4_ModuloGarcom;
using ControleDeBar.Dominio._2._6_ModuloPedido;
using ControleDeBar.Dominio._2._7_ModuloProduto;
using ControleDeBar.Infra.Orm._3._1._1_Compartilhado;


namespace ControleDeBar.WinApp._1._4_ModuloPedido
{
    public partial class TelaPedidoForm : Form
    {
        public Pedido Pedido
        {
            get => pedido;
            set
            {
                txtId.Text = value.Id.ToString();
                cmbGarcom.SelectedItem = value.Garcom;
                cmbProduto.SelectedItem = value.Produto;
                txtQnt.Value = value.Quantidade;
                txtTotal.Text = value.Valor.ToString();
            }
        }
        private Pedido pedido;
        ControleDeBarDbContext dbContext;

        public TelaPedidoForm(ControleDeBarDbContext dbContext)
        {
            InitializeComponent();

            this.dbContext = dbContext;

            MostrarId([.. dbContext.Pedidos]);
            CarregarGarcons();
            CarregarProdutos();
        }

        private void CarregarGarcons()
        {
            List<Garcom> garconsCadastrados = [];

            foreach (Garcom g in garconsCadastrados)
                cmbGarcom.Items.Add(g);
        }
        private void CarregarProdutos()
        {
            List<Produto> produtosCadastrados = [];

            foreach (Produto p in produtosCadastrados)
                cmbProduto.Items.Add(p);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (QuantidadeZero()) return;

            decimal valorTotal = ((Produto)cmbProduto.SelectedItem).Preco * txtQnt.Value;

            txtTotal.Text = valorTotal.ToString();

            pedido = new Pedido(/*(Garcom)cmbGarcom.SelectedItem, */ null, (Produto)cmbProduto.SelectedItem, txtQnt.Value, valorTotal);

            Validar();
        }

        #region Auxiliares
        private void MostrarId(List<Pedido> pedidosCadastrados)
        {
            if (txtId.Text == "0")
            {
                if (pedidosCadastrados.Count > 0)
                    txtId.Text = (pedidosCadastrados.Last().Id + 1).ToString();
                else txtId.Text = "1";
            }
        }
        private void cmbProduto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtQnt.Enabled = true;
            txtQnt.Value = 0;
            txtTotal.Text = "0";
        }
        private void txtQnt_ValueChanged(object sender, EventArgs e) => lblAumentarQnt.Visible = txtQnt.Value == 0;
        private bool QuantidadeZero()
        {
            if (txtQnt.Value == 0)
            {
                lblAumentarQnt.Visible = true;
                DialogResult = DialogResult.None;
                return true;
            }
            return false;
        }
        private void Validar()
        {
            List<string> erros = pedido.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
        #endregion
    }
}
