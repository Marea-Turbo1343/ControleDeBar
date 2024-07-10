namespace ControleDeBar.WinApp._1._6_ModuloConta
{
    partial class TelaFaturamentoForm
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
            groupBox = new GroupBox();
            rdbFaturamentoSempre = new RadioButton();
            txtTerminoPeriodo = new DateTimePicker();
            txtInicioPeriodo = new DateTimePicker();
            label1 = new Label();
            lblInicioPeriodo = new Label();
            rdbFaturamentoPeriodo = new RadioButton();
            rdbFaturamentoMes = new RadioButton();
            rdbFaturamentoSemana = new RadioButton();
            rdbFaturamentoDia = new RadioButton();
            lblSting = new Label();
            faturamentoCalculado = new Label();
            btnCalcular = new Button();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(rdbFaturamentoSempre);
            groupBox.Controls.Add(txtTerminoPeriodo);
            groupBox.Controls.Add(txtInicioPeriodo);
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(lblInicioPeriodo);
            groupBox.Controls.Add(rdbFaturamentoPeriodo);
            groupBox.Controls.Add(rdbFaturamentoMes);
            groupBox.Controls.Add(rdbFaturamentoSemana);
            groupBox.Controls.Add(rdbFaturamentoDia);
            groupBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox.Location = new Point(12, 12);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(406, 238);
            groupBox.TabIndex = 12;
            groupBox.TabStop = false;
            groupBox.Text = "Selecione um Filtro:";
            // 
            // rdbFaturamentoSempre
            // 
            rdbFaturamentoSempre.AutoSize = true;
            rdbFaturamentoSempre.Location = new Point(24, 33);
            rdbFaturamentoSempre.Name = "rdbFaturamentoSempre";
            rdbFaturamentoSempre.Size = new Size(78, 24);
            rdbFaturamentoSempre.TabIndex = 3;
            rdbFaturamentoSempre.TabStop = true;
            rdbFaturamentoSempre.Text = "Sempre";
            rdbFaturamentoSempre.UseVisualStyleBackColor = true;
            // 
            // txtTerminoPeriodo
            // 
            txtTerminoPeriodo.Enabled = false;
            txtTerminoPeriodo.Format = DateTimePickerFormat.Short;
            txtTerminoPeriodo.Location = new Point(276, 183);
            txtTerminoPeriodo.Name = "txtTerminoPeriodo";
            txtTerminoPeriodo.Size = new Size(123, 27);
            txtTerminoPeriodo.TabIndex = 2;
            txtTerminoPeriodo.Value = new DateTime(2024, 5, 30, 0, 0, 0, 0);
            // 
            // txtInicioPeriodo
            // 
            txtInicioPeriodo.Enabled = false;
            txtInicioPeriodo.Format = DateTimePickerFormat.Short;
            txtInicioPeriodo.Location = new Point(76, 183);
            txtInicioPeriodo.Name = "txtInicioPeriodo";
            txtInicioPeriodo.Size = new Size(123, 27);
            txtInicioPeriodo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 186);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "Término:";
            // 
            // lblInicioPeriodo
            // 
            lblInicioPeriodo.AutoSize = true;
            lblInicioPeriodo.Location = new Point(22, 186);
            lblInicioPeriodo.Name = "lblInicioPeriodo";
            lblInicioPeriodo.Size = new Size(48, 20);
            lblInicioPeriodo.TabIndex = 1;
            lblInicioPeriodo.Text = "Início:";
            // 
            // rdbFaturamentoPeriodo
            // 
            rdbFaturamentoPeriodo.AutoSize = true;
            rdbFaturamentoPeriodo.Location = new Point(24, 153);
            rdbFaturamentoPeriodo.Name = "rdbFaturamentoPeriodo";
            rdbFaturamentoPeriodo.Size = new Size(149, 24);
            rdbFaturamentoPeriodo.TabIndex = 0;
            rdbFaturamentoPeriodo.TabStop = true;
            rdbFaturamentoPeriodo.Text = "Período especifico";
            rdbFaturamentoPeriodo.UseVisualStyleBackColor = true;
            rdbFaturamentoPeriodo.CheckedChanged += rdbFaturamentoPeriodo_CheckedChanged;
            // 
            // rdbFaturamentoMes
            // 
            rdbFaturamentoMes.AutoSize = true;
            rdbFaturamentoMes.Location = new Point(24, 123);
            rdbFaturamentoMes.Name = "rdbFaturamentoMes";
            rdbFaturamentoMes.Size = new Size(103, 24);
            rdbFaturamentoMes.TabIndex = 0;
            rdbFaturamentoMes.TabStop = true;
            rdbFaturamentoMes.Text = "Ultimo mês";
            rdbFaturamentoMes.UseVisualStyleBackColor = true;
            // 
            // rdbFaturamentoSemana
            // 
            rdbFaturamentoSemana.AutoSize = true;
            rdbFaturamentoSemana.Location = new Point(24, 93);
            rdbFaturamentoSemana.Name = "rdbFaturamentoSemana";
            rdbFaturamentoSemana.Size = new Size(126, 24);
            rdbFaturamentoSemana.TabIndex = 0;
            rdbFaturamentoSemana.TabStop = true;
            rdbFaturamentoSemana.Text = "Ultima semana";
            rdbFaturamentoSemana.UseVisualStyleBackColor = true;
            // 
            // rdbFaturamentoDia
            // 
            rdbFaturamentoDia.AutoSize = true;
            rdbFaturamentoDia.Location = new Point(24, 63);
            rdbFaturamentoDia.Name = "rdbFaturamentoDia";
            rdbFaturamentoDia.Size = new Size(93, 24);
            rdbFaturamentoDia.TabIndex = 0;
            rdbFaturamentoDia.TabStop = true;
            rdbFaturamentoDia.Text = "Dia (hoje)";
            rdbFaturamentoDia.UseVisualStyleBackColor = true;
            // 
            // lblSting
            // 
            lblSting.AutoSize = true;
            lblSting.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSting.Location = new Point(152, 279);
            lblSting.Name = "lblSting";
            lblSting.Size = new Size(152, 21);
            lblSting.TabIndex = 13;
            lblSting.Text = "Faturamento Total:";
            // 
            // faturamentoCalculado
            // 
            faturamentoCalculado.AutoSize = true;
            faturamentoCalculado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            faturamentoCalculado.ForeColor = Color.LimeGreen;
            faturamentoCalculado.Location = new Point(344, 275);
            faturamentoCalculado.Name = "faturamentoCalculado";
            faturamentoCalculado.Size = new Size(36, 25);
            faturamentoCalculado.TabIndex = 14;
            faturamentoCalculado.Text = "---";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(29, 275);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(95, 30);
            btnCalcular.TabIndex = 15;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // TelaFaturamentoForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(430, 328);
            Controls.Add(btnCalcular);
            Controls.Add(faturamentoCalculado);
            Controls.Add(lblSting);
            Controls.Add(groupBox);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "TelaFaturamentoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Faturamento";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox;
        private DateTimePicker txtTerminoPeriodo;
        private DateTimePicker txtInicioPeriodo;
        private Label label1;
        private Label lblInicioPeriodo;
        private RadioButton rdbFaturamentoPeriodo;
        private RadioButton rdbFaturamentoMes;
        private RadioButton rdbFaturamentoSemana;
        private RadioButton rdbFaturamentoDia;
        private Label lblSting;
        private Label faturamentoCalculado;
        private Button btnCalcular;
        private RadioButton rdbFaturamentoSempre;
    }
}