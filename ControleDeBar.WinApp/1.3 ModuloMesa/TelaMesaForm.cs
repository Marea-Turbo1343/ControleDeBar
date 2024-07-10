using ControleDeBar.Dominio._2._5_ModuloMesa;
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

namespace ControleDeBar.WinApp._1._3_ModuloMesa
{
    public partial class TelaMesaForm : Form
    {
        public Mesa Mesa
        {
            get => mesa;
            set
            {
                txtId.Text = value.Id.ToString();
                txtNumero.Value = numeroAtual = Convert.ToDecimal(value.Numero);
            }
        }
        private Mesa mesa;
        private ControleDeBarDbContext dbContext;
        private decimal numeroAtual;

        public TelaMesaForm(ControleDeBarDbContext dbContext)
        {
            InitializeComponent();

            this.dbContext = dbContext;
            MostrarId();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            mesa = new(txtNumero.Value);

            Validar();
        }

        #region Auxiliares
        private void MostrarId()
        {
            if (txtId.Text == "0")
            {
                if (dbContext.Mesas.ToList().Count > 0)
                    txtId.Text = (dbContext.Mesas.ToList().Last().Id + 1).ToString();
                else txtId.Text = "1";
            }
        }
        private void Validar()
        {
            List<string> erros = mesa.Validar();

            if (MesaTemNumeroDuplicado())
                erros.Add("Já existe uma mesa com este número, tente utilizar outro!");

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
        private bool MesaTemNumeroDuplicado()
        {
            if (numeroAtual == mesa.Numero) return false;
            return dbContext.Mesas.ToList().Any(m => m.Numero == mesa.Numero);
        }
        #endregion
    }
}
