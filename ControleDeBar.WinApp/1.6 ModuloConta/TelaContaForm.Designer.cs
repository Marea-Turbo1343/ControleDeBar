namespace ControleDeBar.WinApp._1._6_ModuloConta
{
    partial class TelaContaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGravar = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            txtId = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            listPedidos = new ListBox();
            btnRemover = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            txtQuantidade = new NumericUpDown();
            label7 = new Label();
            cmbProduto = new ComboBox();
            label6 = new Label();
            label1 = new Label();
            cmbMesa = new ComboBox();
            cmbGarcom = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            lblValorTotal = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(420, 434);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 11;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(12, 434);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 24);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 16;
            label2.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(86, 21);
            txtId.Name = "txtId";
            txtId.Size = new Size(52, 23);
            txtId.TabIndex = 25;
            txtId.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(txtQuantidade);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbProduto);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(8, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(493, 293);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de Pedidos:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonFace;
            groupBox2.Controls.Add(listPedidos);
            groupBox2.Controls.Add(btnRemover);
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Location = new Point(9, 75);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(474, 218);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pedidos:";
            // 
            // listPedidos
            // 
            listPedidos.BorderStyle = BorderStyle.None;
            listPedidos.FormattingEnabled = true;
            listPedidos.ItemHeight = 15;
            listPedidos.Location = new Point(0, 66);
            listPedidos.Name = "listPedidos";
            listPedidos.Size = new Size(474, 150);
            listPedidos.TabIndex = 9;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(92, 27);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 8;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(11, 27);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(387, 34);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Enabled = false;
            txtQuantidade.Location = new Point(314, 34);
            txtQuantidade.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(52, 23);
            txtQuantidade.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(236, 37);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 33;
            label7.Text = "Quantidade:";
            // 
            // cmbProduto
            // 
            cmbProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(87, 33);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(127, 23);
            cmbProduto.TabIndex = 3;
            cmbProduto.SelectionChangeCommitted += cmbProduto_SelectionChangeCommitted;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 36);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 30;
            label6.Text = "Produto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 53);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 28;
            label1.Text = "Mesa:";
            // 
            // cmbMesa
            // 
            cmbMesa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMesa.FormattingEnabled = true;
            cmbMesa.Location = new Point(86, 50);
            cmbMesa.Name = "cmbMesa";
            cmbMesa.Size = new Size(127, 23);
            cmbMesa.TabIndex = 0;
            // 
            // cmbGarcom
            // 
            cmbGarcom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGarcom.FormattingEnabled = true;
            cmbGarcom.Location = new Point(310, 50);
            cmbGarcom.Name = "cmbGarcom";
            cmbGarcom.Size = new Size(135, 23);
            cmbGarcom.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 53);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 30;
            label3.Text = "Garçom:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 92);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 32;
            label4.Text = "Valor total:";
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.ForeColor = Color.LimeGreen;
            lblValorTotal.Location = new Point(85, 92);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(13, 15);
            lblValorTotal.TabIndex = 33;
            lblValorTotal.Text = "0";
            // 
            // TelaContaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 469);
            Controls.Add(lblValorTotal);
            Controls.Add(label4);
            Controls.Add(cmbGarcom);
            Controls.Add(label3);
            Controls.Add(cmbMesa);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(txtId);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaContaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Administração de Conta";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private Label label2;
        private TextBox txtId;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cmbMesa;
        private ComboBox cmbGarcom;
        private Label label3;
        private Label label4;
        private Label lblValorTotal;
        private ComboBox cmbProduto;
        private Label label6;
        private Button btnAdicionar;
        private NumericUpDown txtQuantidade;
        private Label label7;
        private GroupBox groupBox2;
        private Button btnRemover;
        private Button btnEditar;
        private ListBox listPedidos;
    }
}