using ControleDeBar.Infra.Orm._3._1._1_Compartilhado;
using ControleDeBar.WinApp._1._1_Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.WinApp._1._4_ModuloPedido
{
    public class ControladorPedido(IRepositorioPedido repositorioPedido, ControleDeBarDbContext dbContext) : ControladorBase
    {
        TabelaPedidoControl tabelaPedido;

        #region ToolTips
        public override string TipoCadastro { get => "Pedido"; }
        public override string ToolTipAdicionar { get => "Cadastrar um novo pedido"; }
        public override string ToolTipEditar { get => "Editar um pedido existente"; }
        public override string ToolTipExcluir { get => "Excluir um pedido existente"; }
        #endregion

        #region CRUD
        public override void Adicionar()
        {
            TelaPedidoForm telaPedido = new(dbContext);
            DialogResult resultado = telaPedido.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Pedido novoRegistro = telaPedido.Pedido;

            RealizarAcao(
                () => repositorioPedido.Cadastrar(novoRegistro),
                novoRegistro, "cadastrado");
        }
        public override void Editar()
        {
            int idSelecionado = tabelaPedido.ObterRegistroSelecionado();

            Pedido registroSelecionado = repositorioPedido.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado)) return;

            List<Pedido> disciplinasCadastradas = repositorioPedido.SelecionarTodos();

            TelaPedidoForm telaPedido = new(dbContext)
            {
                Pedido = registroSelecionado
            };

            DialogResult resultado = telaPedido.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Pedido registroEditado = telaPedido.Pedido;

            RealizarAcao(
                () => repositorioPedido.Editar(registroSelecionado.Id, registroEditado),
                registroEditado, "editado");
        }
        public override void Excluir()
        {
            int idSelecionado = tabelaPedido.ObterRegistroSelecionado();

            Pedido registroSelecionado = repositorioPedido.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado) || !DesejaRealmenteExcluir(registroSelecionado)) return;

            RealizarAcao(
                () => repositorioPedido.Excluir(registroSelecionado.Id),
                registroSelecionado, "excluído");
        }
        #endregion

        public override UserControl ObterListagem()
        {
            tabelaPedido ??= new();

            CarregarRegistros();

            return tabelaPedido;
        }
        public override void CarregarRegistros()
            => tabelaPedido.AtualizarRegistros(repositorioPedido.SelecionarTodos());
    }
}
