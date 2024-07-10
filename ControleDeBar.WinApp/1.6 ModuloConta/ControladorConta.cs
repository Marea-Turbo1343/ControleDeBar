using ControleDeBar.Dominio._2._3_ModuloConta;
using ControleDeBar.Dominio._2._6_ModuloPedido;
using ControleDeBar.Infra.Orm._3._1._1_Compartilhado;
using ControleDeBar.WinApp._1._1_Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.WinApp._1._6_ModuloConta
{
    public class ControladorConta(IRepositorioConta repositorioConta, IRepositorioPedido repositorioPedido, ControleDeBarDbContext dbContext) : ControladorBase
    {
        TabelaContaControl tabelaConta;
        IRepositorioConta RepositorioConta = repositorioConta;

        #region ToolTips
        public override string TipoCadastro { get => "Conta"; }
        public override string ToolTipAdicionar { get => "Cadastrar uma nova conta"; }
        public override string ToolTipEditar { get => "Editar uma conta existente"; }
        public override string ToolTipExcluir { get => "Excluir uma conta existente"; }
        public string ToolTipContasAbertas { get => "Visualizar contas abertas"; }
        public string ToolTipFecharConta { get => "Fechar conta"; }
        #endregion

        #region CRUD
        public override void Adicionar()
        {
            TelaContaForm telaProduto = new(dbContext);
            DialogResult resultado = telaProduto.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Conta novoRegistro = telaProduto.Conta;

            foreach (Pedido p in novoRegistro.Pedidos)
                repositorioPedido.Cadastrar(p);

            RealizarAcao(
                () => repositorioConta.Cadastrar(novoRegistro),
                novoRegistro, "cadastrado");
        }
        public override void Editar()
        {
            int idSelecionado = tabelaConta.ObterIdSelecionado();

            Conta registroSelecionado = repositorioConta.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado)) return;

            List<Conta> disciplinasCadastradas = repositorioConta.SelecionarTodos();

            TelaContaForm telaConta = new(dbContext)
            {
                Conta = registroSelecionado
            };

            DialogResult resultado = telaConta.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Conta registroEditado = telaConta.Conta;

            RealizarAcao(
                () => repositorioConta.Editar(registroSelecionado.Id, registroEditado),
                registroEditado, "editado");
        }
        public override void Excluir()
        {
            int idSelecionado = tabelaConta.ObterIdSelecionado();

            Conta registroSelecionado = repositorioConta.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado) || !DesejaRealmenteExcluir(registroSelecionado)) return;

            RealizarAcao(
                () => repositorioConta.Excluir(registroSelecionado.Id),
                registroSelecionado, "excluído");
        }
        #endregion
        public void ExibirFaturamento()
        {
            TelaFaturamentoForm telaFaturamento = new(repositorioConta);
            DialogResult resultado = telaFaturamento.ShowDialog();
        }

        public void FecharConta()
        {
            int idSelecionado = tabelaConta.ObterIdSelecionado();

            Conta registroSelecionado = repositorioConta.SelecionarPorId(idSelecionado);

            if (registroSelecionado.EmAberto == false)
            {
                MessageBox.Show(
                $"Esta conta já foi fechada",
                $"Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                return;
            }

            if (SemSeleção(registroSelecionado) || !DesejaRealmenteFecharConta(registroSelecionado)) return;

            registroSelecionado.EmAberto = false;

            RealizarAcao(
                () => repositorioConta.Editar(registroSelecionado.Id, registroSelecionado),
                registroSelecionado);
        }

        public override UserControl ObterListagem()
        {
            tabelaConta ??= new();

            CarregarRegistros();

            return tabelaConta;
        }

        public override void CarregarRegistros()
            => tabelaConta.AtualizarRegistros(repositorioConta.SelecionarTodos());
        public void CarregarContasEmAberto()
            => tabelaConta.AtualizarRegistros(repositorioConta.SelecionarTodos());
        protected bool DesejaRealmenteFecharConta(Conta entidadeSelecionada)
        {
            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente fechar esta conta \"Valor: {entidadeSelecionada.ValorTotal}\"?",
                $"Confirmar pagamento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes) return false;
            return true;
        }
        protected void RealizarAcao(Action acao, Conta conta)
        {
            acao();
            CarregarContasEmAberto();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"A conta \"Valor: {conta.ValorTotal}\" foi fechada com sucesso!");
        }
    }
}
