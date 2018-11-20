namespace PI.WindownsFoms.Formularios
{
    partial class FormPapel
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
            this.txtDescricaoPapel = new System.Windows.Forms.TextBox();
            this.btnSalvarPapel = new System.Windows.Forms.Button();
            this.btnEditarPapel = new System.Windows.Forms.Button();
            this.btnExcluirPapel = new System.Windows.Forms.Button();
            this.dataGridPapel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPapel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDescricaoPapel
            // 
            this.txtDescricaoPapel.Location = new System.Drawing.Point(127, 36);
            this.txtDescricaoPapel.Name = "txtDescricaoPapel";
            this.txtDescricaoPapel.Size = new System.Drawing.Size(315, 22);
            this.txtDescricaoPapel.TabIndex = 1;
            // 
            // btnSalvarPapel
            // 
            this.btnSalvarPapel.Location = new System.Drawing.Point(36, 100);
            this.btnSalvarPapel.Name = "btnSalvarPapel";
            this.btnSalvarPapel.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarPapel.TabIndex = 2;
            this.btnSalvarPapel.Text = "Salvar";
            this.btnSalvarPapel.UseVisualStyleBackColor = true;
            this.btnSalvarPapel.Click += new System.EventHandler(this.btnSalvarPapel_Click);
            // 
            // btnEditarPapel
            // 
            this.btnEditarPapel.Location = new System.Drawing.Point(201, 100);
            this.btnEditarPapel.Name = "btnEditarPapel";
            this.btnEditarPapel.Size = new System.Drawing.Size(75, 23);
            this.btnEditarPapel.TabIndex = 3;
            this.btnEditarPapel.Text = "Editar";
            this.btnEditarPapel.UseVisualStyleBackColor = true;
            this.btnEditarPapel.Click += new System.EventHandler(this.btnEditarPapel_Click);
            // 
            // btnExcluirPapel
            // 
            this.btnExcluirPapel.Location = new System.Drawing.Point(366, 100);
            this.btnExcluirPapel.Name = "btnExcluirPapel";
            this.btnExcluirPapel.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirPapel.TabIndex = 4;
            this.btnExcluirPapel.Text = "Excluir";
            this.btnExcluirPapel.UseVisualStyleBackColor = true;
            this.btnExcluirPapel.Click += new System.EventHandler(this.btnExcluirPapel_Click);
            // 
            // dataGridPapel
            // 
            this.dataGridPapel.AllowUserToAddRows = false;
            this.dataGridPapel.AllowUserToDeleteRows = false;
            this.dataGridPapel.AllowUserToResizeColumns = false;
            this.dataGridPapel.AllowUserToResizeRows = false;
            this.dataGridPapel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPapel.Location = new System.Drawing.Point(12, 149);
            this.dataGridPapel.Name = "dataGridPapel";
            this.dataGridPapel.ReadOnly = true;
            this.dataGridPapel.RowTemplate.Height = 24;
            this.dataGridPapel.Size = new System.Drawing.Size(776, 289);
            this.dataGridPapel.TabIndex = 5;
            this.dataGridPapel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormPapel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridPapel);
            this.Controls.Add(this.btnExcluirPapel);
            this.Controls.Add(this.btnEditarPapel);
            this.Controls.Add(this.btnSalvarPapel);
            this.Controls.Add(this.txtDescricaoPapel);
            this.Controls.Add(this.label1);
            this.Name = "FormPapel";
            this.Text = "Controle de Papeis";
            this.Load += new System.EventHandler(this.FormPapel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPapel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricaoPapel;
        private System.Windows.Forms.Button btnSalvarPapel;
        private System.Windows.Forms.Button btnEditarPapel;
        private System.Windows.Forms.Button btnExcluirPapel;
        private System.Windows.Forms.DataGridView dataGridPapel;
    }
}