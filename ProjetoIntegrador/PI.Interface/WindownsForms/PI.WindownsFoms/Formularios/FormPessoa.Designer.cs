namespace PI.WindownsFoms.Formularios
{
    partial class FormPessoa
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
            this.dataGridPessoa = new System.Windows.Forms.DataGridView();
            this.btnExcluirPessoa = new System.Windows.Forms.Button();
            this.btnEditarPessoa = new System.Windows.Forms.Button();
            this.btnSalvarPessoa = new System.Windows.Forms.Button();
            this.txtDescricaoPessoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPessoa
            // 
            this.dataGridPessoa.AllowUserToAddRows = false;
            this.dataGridPessoa.AllowUserToDeleteRows = false;
            this.dataGridPessoa.AllowUserToResizeColumns = false;
            this.dataGridPessoa.AllowUserToResizeRows = false;
            this.dataGridPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPessoa.Location = new System.Drawing.Point(12, 137);
            this.dataGridPessoa.Name = "dataGridPessoa";
            this.dataGridPessoa.ReadOnly = true;
            this.dataGridPessoa.RowHeadersWidth = 5;
            this.dataGridPessoa.RowTemplate.Height = 24;
            this.dataGridPessoa.Size = new System.Drawing.Size(776, 289);
            this.dataGridPessoa.TabIndex = 11;
            // 
            // btnExcluirPessoa
            // 
            this.btnExcluirPessoa.Location = new System.Drawing.Point(366, 88);
            this.btnExcluirPessoa.Name = "btnExcluirPessoa";
            this.btnExcluirPessoa.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirPessoa.TabIndex = 10;
            this.btnExcluirPessoa.Text = "Excluir";
            this.btnExcluirPessoa.UseVisualStyleBackColor = true;
            this.btnExcluirPessoa.Click += new System.EventHandler(this.btnExcluirPessoa_Click);
            // 
            // btnEditarPessoa
            // 
            this.btnEditarPessoa.Location = new System.Drawing.Point(201, 88);
            this.btnEditarPessoa.Name = "btnEditarPessoa";
            this.btnEditarPessoa.Size = new System.Drawing.Size(75, 23);
            this.btnEditarPessoa.TabIndex = 9;
            this.btnEditarPessoa.Text = "Editar";
            this.btnEditarPessoa.UseVisualStyleBackColor = true;
            this.btnEditarPessoa.Click += new System.EventHandler(this.btnEditarPessoa_Click);
            // 
            // btnSalvarPessoa
            // 
            this.btnSalvarPessoa.Location = new System.Drawing.Point(36, 88);
            this.btnSalvarPessoa.Name = "btnSalvarPessoa";
            this.btnSalvarPessoa.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarPessoa.TabIndex = 8;
            this.btnSalvarPessoa.Text = "Salvar";
            this.btnSalvarPessoa.UseVisualStyleBackColor = true;
            this.btnSalvarPessoa.Click += new System.EventHandler(this.btnSalvarPessoa_Click);
            // 
            // txtDescricaoPessoa
            // 
            this.txtDescricaoPessoa.Location = new System.Drawing.Point(127, 24);
            this.txtDescricaoPessoa.Name = "txtDescricaoPessoa";
            this.txtDescricaoPessoa.Size = new System.Drawing.Size(661, 22);
            this.txtDescricaoPessoa.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // FormPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.dataGridPessoa);
            this.Controls.Add(this.btnExcluirPessoa);
            this.Controls.Add(this.btnEditarPessoa);
            this.Controls.Add(this.btnSalvarPessoa);
            this.Controls.Add(this.txtDescricaoPessoa);
            this.Controls.Add(this.label1);
            this.Name = "FormPessoa";
            this.Text = "Cadastro de Pessoa";
            this.Load += new System.EventHandler(this.FormPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPessoa;
        private System.Windows.Forms.Button btnExcluirPessoa;
        private System.Windows.Forms.Button btnEditarPessoa;
        private System.Windows.Forms.Button btnSalvarPessoa;
        private System.Windows.Forms.TextBox txtDescricaoPessoa;
        private System.Windows.Forms.Label label1;
    }
}