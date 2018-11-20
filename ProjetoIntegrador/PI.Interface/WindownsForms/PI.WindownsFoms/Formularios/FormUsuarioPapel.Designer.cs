namespace PI.WindownsFoms.Formularios
{
    partial class FormUsuarioPapel
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPapel = new System.Windows.Forms.Label();
            this.cboUsuario = new System.Windows.Forms.ComboBox();
            this.cboPapel = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAtivarDesativar = new System.Windows.Forms.Button();
            this.gridViewUsuarioPapel = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsuarioPapel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 30);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 17);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblPapel
            // 
            this.lblPapel.AutoSize = true;
            this.lblPapel.Location = new System.Drawing.Point(12, 90);
            this.lblPapel.Name = "lblPapel";
            this.lblPapel.Size = new System.Drawing.Size(48, 17);
            this.lblPapel.TabIndex = 1;
            this.lblPapel.Text = "Papel:";
            // 
            // cboUsuario
            // 
            this.cboUsuario.FormattingEnabled = true;
            this.cboUsuario.Location = new System.Drawing.Point(89, 30);
            this.cboUsuario.Name = "cboUsuario";
            this.cboUsuario.Size = new System.Drawing.Size(777, 24);
            this.cboUsuario.TabIndex = 2;
            // 
            // cboPapel
            // 
            this.cboPapel.FormattingEnabled = true;
            this.cboPapel.Location = new System.Drawing.Point(89, 83);
            this.cboPapel.Name = "cboPapel";
            this.cboPapel.Size = new System.Drawing.Size(777, 24);
            this.cboPapel.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(15, 139);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(137, 41);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAtivarDesativar
            // 
            this.btnAtivarDesativar.Location = new System.Drawing.Point(708, 139);
            this.btnAtivarDesativar.Name = "btnAtivarDesativar";
            this.btnAtivarDesativar.Size = new System.Drawing.Size(158, 41);
            this.btnAtivarDesativar.TabIndex = 5;
            this.btnAtivarDesativar.Text = "Ativar/Desativar";
            this.btnAtivarDesativar.UseVisualStyleBackColor = true;
            this.btnAtivarDesativar.Click += new System.EventHandler(this.btnAtivarDesativar_Click);
            // 
            // gridViewUsuarioPapel
            // 
            this.gridViewUsuarioPapel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewUsuarioPapel.Location = new System.Drawing.Point(12, 186);
            this.gridViewUsuarioPapel.Name = "gridViewUsuarioPapel";
            this.gridViewUsuarioPapel.RowTemplate.Height = 24;
            this.gridViewUsuarioPapel.Size = new System.Drawing.Size(854, 252);
            this.gridViewUsuarioPapel.TabIndex = 6;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(360, 139);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(137, 41);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // FormUsuarioPapel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 463);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.gridViewUsuarioPapel);
            this.Controls.Add(this.btnAtivarDesativar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cboPapel);
            this.Controls.Add(this.cboUsuario);
            this.Controls.Add(this.lblPapel);
            this.Controls.Add(this.lblUsuario);
            this.Name = "FormUsuarioPapel";
            this.Text = "FormUsuarioPapel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUsuarioPapel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsuarioPapel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPapel;
        private System.Windows.Forms.ComboBox cboUsuario;
        private System.Windows.Forms.ComboBox cboPapel;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAtivarDesativar;
        private System.Windows.Forms.DataGridView gridViewUsuarioPapel;
        private System.Windows.Forms.Button btnExcluir;
    }
}