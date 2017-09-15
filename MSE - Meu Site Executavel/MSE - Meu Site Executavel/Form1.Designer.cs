namespace MSE___Meu_Site_Executavel
{
    partial class MSE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_url = new System.Windows.Forms.TextBox();
            this.btn_addURL = new System.Windows.Forms.Button();
            this.btn_removerDaLbx = new System.Windows.Forms.Button();
            this.lbx_URLadds = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_geraExe = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meuSiteExecutavelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programdorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meu Site Executavel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escreva a URL aqui:";
            // 
            // txb_url
            // 
            this.txb_url.Location = new System.Drawing.Point(190, 97);
            this.txb_url.Name = "txb_url";
            this.txb_url.Size = new System.Drawing.Size(422, 27);
            this.txb_url.TabIndex = 2;
            // 
            // btn_addURL
            // 
            this.btn_addURL.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_addURL.Location = new System.Drawing.Point(468, 163);
            this.btn_addURL.Name = "btn_addURL";
            this.btn_addURL.Size = new System.Drawing.Size(110, 70);
            this.btn_addURL.TabIndex = 3;
            this.btn_addURL.Text = "Adicionar URL";
            this.btn_addURL.UseVisualStyleBackColor = false;
            this.btn_addURL.Click += new System.EventHandler(this.btn_addURL_Click);
            // 
            // btn_removerDaLbx
            // 
            this.btn_removerDaLbx.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_removerDaLbx.Location = new System.Drawing.Point(468, 239);
            this.btn_removerDaLbx.Name = "btn_removerDaLbx";
            this.btn_removerDaLbx.Size = new System.Drawing.Size(110, 70);
            this.btn_removerDaLbx.TabIndex = 4;
            this.btn_removerDaLbx.Text = "Remover URL";
            this.btn_removerDaLbx.UseVisualStyleBackColor = false;
            this.btn_removerDaLbx.Click += new System.EventHandler(this.btn_removerDaLbx_Click);
            // 
            // lbx_URLadds
            // 
            this.lbx_URLadds.FormattingEnabled = true;
            this.lbx_URLadds.ItemHeight = 18;
            this.lbx_URLadds.Location = new System.Drawing.Point(27, 195);
            this.lbx_URLadds.Name = "lbx_URLadds";
            this.lbx_URLadds.Size = new System.Drawing.Size(378, 184);
            this.lbx_URLadds.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "URL que ja foram adiconadas";
            // 
            // btn_geraExe
            // 
            this.btn_geraExe.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_geraExe.Location = new System.Drawing.Point(468, 315);
            this.btn_geraExe.Name = "btn_geraExe";
            this.btn_geraExe.Size = new System.Drawing.Size(110, 70);
            this.btn_geraExe.TabIndex = 7;
            this.btn_geraExe.Text = "Gera Executavel";
            this.btn_geraExe.UseVisualStyleBackColor = false;
            this.btn_geraExe.Click += new System.EventHandler(this.btn_geraExe_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meuSiteExecutavelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meuSiteExecutavelToolStripMenuItem
            // 
            this.meuSiteExecutavelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreOProgramaToolStripMenuItem,
            this.programdorToolStripMenuItem});
            this.meuSiteExecutavelToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.meuSiteExecutavelToolStripMenuItem.Name = "meuSiteExecutavelToolStripMenuItem";
            this.meuSiteExecutavelToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.meuSiteExecutavelToolStripMenuItem.Text = "Meu Site Executavel";
            // 
            // sobreOProgramaToolStripMenuItem
            // 
            this.sobreOProgramaToolStripMenuItem.Name = "sobreOProgramaToolStripMenuItem";
            this.sobreOProgramaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.sobreOProgramaToolStripMenuItem.Text = "Sobre o programa";
            this.sobreOProgramaToolStripMenuItem.Click += new System.EventHandler(this.sobreOProgramaToolStripMenuItem_Click);
            // 
            // programdorToolStripMenuItem
            // 
            this.programdorToolStripMenuItem.Name = "programdorToolStripMenuItem";
            this.programdorToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.programdorToolStripMenuItem.Text = "Programador";
            this.programdorToolStripMenuItem.Click += new System.EventHandler(this.programdorToolStripMenuItem_Click);
            // 
            // MSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.btn_geraExe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbx_URLadds);
            this.Controls.Add(this.btn_removerDaLbx);
            this.Controls.Add(this.btn_addURL);
            this.Controls.Add(this.txb_url);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MSE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSE - Meu Site Executavel          Versão : 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_url;
        private System.Windows.Forms.Button btn_addURL;
        private System.Windows.Forms.Button btn_removerDaLbx;
        private System.Windows.Forms.ListBox lbx_URLadds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_geraExe;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meuSiteExecutavelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programdorToolStripMenuItem;
    }
}

