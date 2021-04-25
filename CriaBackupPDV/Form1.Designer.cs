namespace CriaBackupPDV
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblVersaoPDV = new System.Windows.Forms.Label();
            this.lblNumeroDraft = new System.Windows.Forms.Label();
            this.txtVersao = new System.Windows.Forms.TextBox();
            this.txtDraft = new System.Windows.Forms.TextBox();
            this.gpbPrincipal = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.cbNomeCliente = new System.Windows.Forms.ComboBox();
            this.gpbPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(6, 36);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCliente.TabIndex = 0;
            this.lblNomeCliente.Text = "Nome do Cliente";
            // 
            // lblVersaoPDV
            // 
            this.lblVersaoPDV.AutoSize = true;
            this.lblVersaoPDV.Location = new System.Drawing.Point(6, 68);
            this.lblVersaoPDV.Name = "lblVersaoPDV";
            this.lblVersaoPDV.Size = new System.Drawing.Size(80, 13);
            this.lblVersaoPDV.TabIndex = 1;
            this.lblVersaoPDV.Text = "Versão do PDV";
            // 
            // lblNumeroDraft
            // 
            this.lblNumeroDraft.AutoSize = true;
            this.lblNumeroDraft.Location = new System.Drawing.Point(6, 100);
            this.lblNumeroDraft.Name = "lblNumeroDraft";
            this.lblNumeroDraft.Size = new System.Drawing.Size(85, 13);
            this.lblNumeroDraft.TabIndex = 2;
            this.lblNumeroDraft.Text = "Número do Draft";
            // 
            // txtVersao
            // 
            this.txtVersao.Location = new System.Drawing.Point(97, 61);
            this.txtVersao.Name = "txtVersao";
            this.txtVersao.Size = new System.Drawing.Size(100, 20);
            this.txtVersao.TabIndex = 4;
            // 
            // txtDraft
            // 
            this.txtDraft.Location = new System.Drawing.Point(97, 93);
            this.txtDraft.Name = "txtDraft";
            this.txtDraft.Size = new System.Drawing.Size(100, 20);
            this.txtDraft.TabIndex = 5;
            // 
            // gpbPrincipal
            // 
            this.gpbPrincipal.BackColor = System.Drawing.Color.White;
            this.gpbPrincipal.Controls.Add(this.cbNomeCliente);
            this.gpbPrincipal.Controls.Add(this.btnFechar);
            this.gpbPrincipal.Controls.Add(this.btnBackup);
            this.gpbPrincipal.Controls.Add(this.lblNomeCliente);
            this.gpbPrincipal.Controls.Add(this.lblVersaoPDV);
            this.gpbPrincipal.Controls.Add(this.lblNumeroDraft);
            this.gpbPrincipal.Controls.Add(this.txtVersao);
            this.gpbPrincipal.Controls.Add(this.txtDraft);
            this.gpbPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gpbPrincipal.Location = new System.Drawing.Point(6, 4);
            this.gpbPrincipal.Name = "gpbPrincipal";
            this.gpbPrincipal.Size = new System.Drawing.Size(357, 180);
            this.gpbPrincipal.TabIndex = 6;
            this.gpbPrincipal.TabStop = false;
            this.gpbPrincipal.Text = "Opções";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(219, 141);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(116, 23);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnBackup.Location = new System.Drawing.Point(97, 141);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(116, 23);
            this.btnBackup.TabIndex = 6;
            this.btnBackup.Text = "Iniciar Backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // cbNomeCliente
            // 
            this.cbNomeCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNomeCliente.FormattingEnabled = true;
            this.cbNomeCliente.Items.AddRange(new object[] {
            "DPSP",
            "EXTRAFARMA",
            "RENNER",
            "TIM"});
            this.cbNomeCliente.Location = new System.Drawing.Point(97, 28);
            this.cbNomeCliente.Name = "cbNomeCliente";
            this.cbNomeCliente.Size = new System.Drawing.Size(121, 21);
            this.cbNomeCliente.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(369, 191);
            this.Controls.Add(this.gpbPrincipal);
            this.ForeColor = System.Drawing.Color.Purple;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CriaBackupPDV 1.0.0";
            this.gpbPrincipal.ResumeLayout(false);
            this.gpbPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblVersaoPDV;
        private System.Windows.Forms.Label lblNumeroDraft;
        private System.Windows.Forms.TextBox txtVersao;
        private System.Windows.Forms.TextBox txtDraft;
        private System.Windows.Forms.GroupBox gpbPrincipal;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.ComboBox cbNomeCliente;
    }
}

