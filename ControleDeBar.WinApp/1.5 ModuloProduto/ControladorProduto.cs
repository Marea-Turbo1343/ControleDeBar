using ControleDeBar.Dominio._2._7_ModuloProduto;
using ControleDeBar.Infra.Orm._3._1._1_Compartilhado;
using ControleDeBar.WinApp._1._1_Compartilhado;

namespace ControleDeBar.WinApp._1._5_ModuloProduto
{
    public class ControladorProduto(IRepositorioProduto repositorioProduto, ControleDeBarDbContext dbContext) : ControladorBase
    {
        TabelaProdutoControl tabelaProduto;

        #region ToolTips
        public override string TipoCadastro { get => "Produto"; }
        public override string ToolTipAdicionar { get => "Cadastrar um novo produto"; }
        public override string ToolTipEditar { get => "Editar um produto existente"; }
        public override string ToolTipExcluir { get => "Excluir um produto existente"; }
        #endregion

        #region CRUD
        public override void Adicionar()
        {
            TelaProdutoForm telaProduto = new([.. dbContext.Produtos]);
            DialogResult resultado = telaProduto.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Produto novoRegistro = telaProduto.Produto;

            RealizarAcao(
                () => repositorioProduto.Cadastrar(novoRegistro),
                novoRegistro, "cadastrado");
        }
        public override void Editar()
        {
            int idSelecionado = tabelaProduto.ObterRegistroSelecionado();

            Produto registroSelecionado = repositorioProduto.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado)) return;

            List<Produto> disciplinasCadastradas = repositorioProduto.SelecionarTodos();

            TelaProdutoForm telaProduto = new([.. dbContext.Produtos])
            {
                Produto = registroSelecionado
            };

            DialogResult resultado = telaProduto.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Produto registroEditado = telaProduto.Produto;

            RealizarAcao(
                () => repositorioProduto.Editar(registroSelecionado.Id, registroEditado),
                registroEditado, "editado");
        }
        public override void Excluir()
        {
            int idSelecionado = tabelaProduto.ObterRegistroSelecionado();

            Produto registroSelecionado = repositorioProduto.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado) || !DesejaRealmenteExcluir(registroSelecionado)) return;

            RealizarAcao(
                () => repositorioProduto.Excluir(registroSelecionado.Id),
                registroSelecionado, "excluído");
        }
        #endregion

        public override UserControl ObterListagem()
        {
            tabelaProduto ??= new();

            CarregarRegistros();

            return tabelaProduto;
        }
        public override void CarregarRegistros()
            => tabelaProduto.AtualizarRegistros(repositorioProduto.SelecionarTodos());
    }
}
