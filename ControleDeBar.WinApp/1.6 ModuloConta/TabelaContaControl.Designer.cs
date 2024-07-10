namespace ControleDeBar.WinApp._1._6_ModuloConta
{
    partial class TabelaContaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listContas = new ListView();
            SuspendLayout();
            // 
            // listContas
            // 
            listContas.Dock = DockStyle.Fill;
            listContas.Location = new Point(0, 0);
            listContas.Name = "listContas";
            listContas.Size = new Size(335, 218);
            listContas.TabIndex = 0;
            listContas.UseCompatibleStateImageBehavior = false;
            // 
            // TabelaContaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listContas);
            Name = "TabelaContaControl";
            Size = new Size(335, 218);
            ResumeLayout(false);
        }

        #endregion

        private ListView listContas;
    }
}
