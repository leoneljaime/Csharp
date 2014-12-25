namespace prjMDI_Consulta
{
    partial class FrmMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkSingleton = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCadastro});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuCadastro
            // 
            this.MnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCliente});
            this.MnuCadastro.Name = "MnuCadastro";
            this.MnuCadastro.Size = new System.Drawing.Size(80, 24);
            this.MnuCadastro.Text = "Cadastro";
            // 
            // MnuCliente
            // 
            this.MnuCliente.Name = "MnuCliente";
            this.MnuCliente.Size = new System.Drawing.Size(175, 24);
            this.MnuCliente.Text = "Cliente";
            this.MnuCliente.Click += new System.EventHandler(this.MnuCliente_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkSingleton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 48);
            this.panel1.TabIndex = 2;
            // 
            // chkSingleton
            // 
            this.chkSingleton.AutoSize = true;
            this.chkSingleton.Location = new System.Drawing.Point(12, 12);
            this.chkSingleton.Name = "chkSingleton";
            this.chkSingleton.Size = new System.Drawing.Size(118, 21);
            this.chkSingleton.TabIndex = 0;
            this.chkSingleton.Text = "Use Singleton";
            this.chkSingleton.UseVisualStyleBackColor = true;
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 364);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMDI";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuCadastro;
        private System.Windows.Forms.ToolStripMenuItem MnuCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkSingleton;
    }
}

