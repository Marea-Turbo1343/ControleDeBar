using ControleDeBar.Dominio._2._3_ModuloConta;
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
    public partial class TabelaContaControl : UserControl
    {
        public TabelaContaControl()
        {
            InitializeComponent();

            ConfigurarColunas();
            ConfigurarListView();
        }

        public void AtualizarRegistros(List<Conta> contas)
        {
            listContas.Items.Clear();
            listContas.Groups.Clear();

            var contasAgrupadas = contas.GroupBy(t => t.EmAberto).OrderByDescending(g => g.Key);

            foreach (var grupo in contasAgrupadas)
            {
                string situacao = grupo.Key ? "Em Aberto" : "Fechadas";
                ListViewGroup listViewGroup =
                    new ListViewGroup($"Contas {situacao}", HorizontalAlignment.Left);

                listContas.Groups.Add(listViewGroup);

                foreach (Conta c in grupo)
                {
                    ListViewItem item = new ListViewItem(c.Id.ToString())
                    {
                        Tag = c,
                    };

                    item.SubItems.Add(c.Mesa.ToString());
                    item.SubItems.Add(c.Garcom.ToString());
                    item.SubItems.Add(c.Data.ToShortDateString());
                    item.SubItems.Add(c.ValorTotal.ToString());

                    item.Group = listViewGroup;

                    listContas.Items.Add(item);
                }
            }

            ConfigurarAparenciaColunas();
        }

        public int ObterIdSelecionado()
        {
            if (listContas.SelectedItems.Count == 0)
                return -1;

            var tarefaSelecionada = (Conta)listContas.SelectedItems[0].Tag;

            return tarefaSelecionada.Id;
        }

        private void ConfigurarColunas()
        {
            ColumnHeader[] colunas = new ColumnHeader[]
            {
                new ColumnHeader() { Text = "Id"},
                new ColumnHeader() { Text = "Mesa", Width = 180},
                new ColumnHeader() { Text = "Garçom", Width = 180},
                new ColumnHeader() { Text = "Data", Width = 180},
                new ColumnHeader() { Text = "Valor Total", Width = 180}
            };

            listContas.Columns.AddRange(colunas);
        }

        private void ConfigurarAparenciaColunas()
        {
            //listContas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            listContas.Columns[0].Width = 80;
            //listContas.Columns[1].Width = 180;
            //listContas.Columns[2].Width = 180;
            //listContas.Columns[3].Width = 180;
            //listContas.Columns[4].Width = 180;
        }

        private void ConfigurarListView()
        {
            listContas.MultiSelect = false;
            listContas.FullRowSelect = true;
            listContas.GridLines = true;

            listContas.View = View.Details;
        }
    }
}
