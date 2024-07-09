using ControleDeBar.Infra.Orm._3._1._1_Compartilhado;
using ControleDeBar.Infra.Orm._3._1._5_ModuloGarcom;
using ControleDeBar.Infra.Orm._3._1._7_ModuloPedido;
using ControleDeBar.Infra.Orm._3._1._8_ModuloProduto;
using ControleDeBar.Dominio._2._1_Compartilhado;
using ControleDeBar.Dominio._2._4_ModuloGarcom;
using ControleDeBar.Dominio._2._6_ModuloPedido;
using ControleDeBar.Dominio._2._7_ModuloProduto;
using ControleDeBar.WinApp._1._1_Compartilhado;
using ControleDeBar.WinApp._1._2_ModuloGarcom;
using ControleDeBar.WinApp._1._4_ModuloPedido;
using ControleDeBar.WinApp._1._5_ModuloProduto;

namespace ControleDeBar.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        public static TelaPrincipalForm Instancia { get; private set; }

        ControladorBase controlador;
        ControleDeBarDbContext dbContext;

        IRepositorioGarcom repositorioGarcom;
        IRepositorioProduto repositorioProduto;
        IRepositorioPedido repositorioPedido;

        public TelaPrincipalForm()
        {
            InitializeComponent();

            lblTipoCadastro.Text = string.Empty;

            dbContext = new();

            repositorioGarcom = new RepositorioGarcomEmOrm(dbContext);
            repositorioProduto = new RepositorioProdutoEmOrm(dbContext);
            repositorioPedido = new RepositorioPedidoEmOrm(dbContext);

            Instancia = this;
        }
        public void AtualizarRodape(string texto) => statusLabelPrincipal.Text = texto;


        #region Seleção de módulo
        private void garcomMenuItem_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorGarcom(repositorioGarcom, dbContext),
                    repositorioGarcom.SelecionarTodos().Count);
        private void produtoMenuItem_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorProduto(repositorioProduto, dbContext),
                    repositorioProduto.SelecionarTodos().Count);
        private void btnCadastroPedido_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorPedido(repositorioPedido, dbContext),
                repositorioPedido.SelecionarTodos().Count);
        private void mesaMenuItem_Click(object sender, EventArgs e) { }
        /*                => SelecionaModulo(ref controlador, () => controlador = new ControladorGarcom(repositorioGarcom),
                    repositorioGarcom.SelecionarTodos().Count);*/
        private void contaMenuItem_Click(object sender, EventArgs e) { }
        /*                => SelecionaModulo(ref controlador, () => controlador = new ControladorGarcom(repositorioGarcom),
                    repositorioGarcom.SelecionarTodos().Count);*/
        private void barMenuItem_Click(object sender, EventArgs e) { }
        /*                => SelecionaModulo(ref controlador, () => controlador = new ControladorGarcom(repositorioGarcom),
                    repositorioGarcom.SelecionarTodos().Count);*/
        #endregion

        #region Botões
        private void btnAdicionar_Click_1(object sender, EventArgs e)
            => controlador.Adicionar();
        private void btnEditar_Click(object sender, EventArgs e)
            => controlador.Editar();
        private void btnExcluir_Click(object sender, EventArgs e)
            => controlador.Excluir();
        #endregion

        #region Auxiliares
        private void SelecionaModulo(ref ControladorBase controlador, Action controladorSelecionado, int numRegistros)
        {
            controladorSelecionado();
            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

            ConfigurarToolBox(controlador);
            ConfigurarListagem(controlador);
            AtualizarRodape($"Visualizando {numRegistros} registro(s)...");
        }
        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;

            btnCadastroPedido.Enabled = controladorSelecionado is IControladorGeraPedido;

            ConfigurarToolTips(controladorSelecionado);
        }
        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;

            if (controladorSelecionado is IControladorGeraPedido controladorGeraPedido)
                btnCadastroPedido.ToolTipText = controladorGeraPedido.ToolTipGerarPedido;
        }
        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemContato = controladorSelecionado.ObterListagem();

            listagemContato.Dock = DockStyle.Fill;
            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemContato);
        }
        #endregion

    }
}
