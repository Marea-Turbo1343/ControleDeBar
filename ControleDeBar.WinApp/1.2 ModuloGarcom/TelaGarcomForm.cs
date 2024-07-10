using ControleDeBar.Dominio._2._1_Compartilhado.Extensions;
using ControleDeBar.Dominio._2._4_ModuloGarcom;
using ControleDeBar.Infra.Orm._3._1._1_Compartilhado;

namespace ControleDeBar.WinApp._1._2_ModuloGarcom
{
    public partial class TelaGarcomForm : Form
    {
        public Garcom Garcom
        {
            get => garcom;
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = nomeAtual = value.Nome;
            }
        }
        private Garcom garcom;
        private ControleDeBarDbContext dbContext;
        private string nomeAtual;

        public TelaGarcomForm(ControleDeBarDbContext dbContext)
        {
            InitializeComponent();

            this.dbContext = dbContext;
            MostrarId();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            garcom = new(txtNome.Text);

            List<string> erros = garcom.Validar();

            Validar(erros);
        }

        #region Auxiliares
        private void Validar(List<string> erros)
        {
            if (GarcomTemNomeDuplicado())
                erros.Add("Já existe um garçom com este nome, tente utilizar outro!");

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
        private bool GarcomTemNomeDuplicado()
        {
            if (nomeAtual == garcom.Nome) return false;
            return dbContext.Garcons.ToList().Any(g => g.Nome.Validation() == garcom.Nome.Validation());
        }
        private void MostrarId()
        {
            if (txtId.Text == "0")
            {
                if (dbContext.Garcons.ToList().Count > 0)
                    txtId.Text = (dbContext.Garcons.ToList().Last().Id + 1).ToString();
                else txtId.Text = "1";
            }
        }
        #endregion
    }
}
