using ControleDeBar.Dominio._2._3_ModuloConta;
using ControleDeBar.Dominio._2._4_ModuloGarcom;
using ControleDeBar.Dominio._2._5_ModuloMesa;
using ControleDeBar.Dominio._2._6_ModuloPedido;
using ControleDeBar.Dominio._2._7_ModuloProduto;
using ControleDeBar.Infra.Orm._3._1._1_Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeBar.WinApp._1._6_ModuloConta
{
    public partial class TelaContaForm : Form
    {
        public Conta Conta
        {
            get => conta;
            set
            {
                txtId.Text = value.Id.ToString();
                cmbGarcom.SelectedItem = value.Garcom;
                cmbMesa.SelectedItem = value.Mesa;
                lblValorTotal.Text = value.ValorTotal.ToString();
                valorTotal = value.ValorTotal;

                foreach (Pedido p in value.Pedidos)
                    listPedidos.Items.Add(p);
            }
        }
        private Conta conta;
        ControleDeBarDbContext dbContext;
        decimal valorTotal = 0;
        bool emEdicao = false;

        public TelaContaForm(ControleDeBarDbContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;

            CarregarMesas();
            CarregarGarcons();
            CarregarProdutos();
            MostrarId([.. dbContext.Contas]);
        }

        private void CarregarMesas()
        {
            List<Mesa> mesasCadastradas = [.. dbContext.Mesas];

            foreach (Mesa m in mesasCadastradas)
                cmbMesa.Items.Add(m);
        }
        private void CarregarGarcons()
        {
            List<Garcom> garconsCadastrados = [.. dbContext.Garcons];

            foreach (Garcom g in garconsCadastrados)
                cmbGarcom.Items.Add(g);
        }
        private void CarregarProdutos()
        {
            List<Produto> produtosCadastrados = [.. dbContext.Produtos];

            foreach (Produto p in produtosCadastrados)
                cmbProduto.Items.Add(p);
        }

        #region Botões
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (QuantidadeZerada() || SemGarcomSelecionado()) return;

            Pedido novoPedido = new(
                (Garcom)cmbGarcom.SelectedItem,
                (Produto)cmbProduto.SelectedItem, txtQuantidade.Value,
                ((Produto)cmbProduto.SelectedItem).Preco * txtQuantidade.Value);

            listPedidos.Items.Add(novoPedido);

            valorTotal += novoPedido.Valor;

            cmbProduto.SelectedItem = null;
            txtQuantidade.Value = 0; txtQuantidade.Enabled = false;
            lblValorTotal.Text = valorTotal.ToString(); lblValorTotal.Visible = true;
            TelaPrincipalForm.Instancia.AtualizarRodape("Pedido adicionado com sucesso!");

            if (emEdicao) listPedidos.Items.Remove(listPedidos.SelectedItem);
            emEdicao = false;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listPedidos.SelectedItem == null) return;

            emEdicao = true;
            cmbProduto.SelectedItem = ((Pedido)listPedidos.SelectedItem).Produto;
            txtQuantidade.Value = ((Pedido)listPedidos.SelectedItem).Quantidade;
            txtQuantidade.Enabled = true;

            btnRemover_Click(sender, e);
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listPedidos.SelectedItem == null) return;

            valorTotal -= ((Pedido)listPedidos.SelectedItem).Valor;
            lblValorTotal.Text = valorTotal.ToString();
            listPedidos.Items.Remove(listPedidos.SelectedItem);
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            List<Pedido> pedidos = [];
            foreach (Pedido p in listPedidos.Items)
                pedidos.Add(p);

            conta = new((Mesa)cmbMesa.SelectedItem, (Garcom)cmbGarcom.SelectedItem, pedidos, valorTotal, true, DateTime.Now);

            List<string> erros = conta.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
        #endregion

        #region Auxiliares
        private void cmbProduto_SelectionChangeCommitted(object sender, EventArgs e) => txtQuantidade.Enabled = true;
        private bool SemGarcomSelecionado()
        {
            if (cmbGarcom.SelectedItem == null)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Não é possível adicionar este pedido. Informe um \"Garçom\"");
                return true;
            }
            return false;
        }
        private bool QuantidadeZerada()
        {
            if (txtQuantidade.Value == 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Não é possível adicionar este pedido. Aumente a quantidade");
                return true;
            }
            return false;
        }
        private void MostrarId(List<Conta> contasCadastradas)
        {
            if (txtId.Text == "0")
            {
                if (contasCadastradas.Count > 0)
                    txtId.Text = (contasCadastradas.Last().Id + 1).ToString();
                else txtId.Text = "1";
            }
        }
        #endregion
    }
}
