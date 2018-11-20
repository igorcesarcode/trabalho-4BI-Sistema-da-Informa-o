namespace PI.WindownsFoms.Formularios
{
    partial class FormCurso
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnSalvarCurso = new System.Windows.Forms.Button();
            this.btnEditarCurso = new System.Windows.Forms.Button();
            this.btnExcluirCurso = new System.Windows.Forms.Button();
            this.dataGridCurso = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Curso ";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(162, 36);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(591, 22);
            this.txtDescricao.TabIndex = 1;
            // 
            // btnSalvarCurso
            // 
            this.btnSalvarCurso.Location = new System.Drawing.Point(30, 335);
            this.btnSalvarCurso.Name = "btnSalvarCurso";
            this.btnSalvarCurso.Size = new System.Drawing.Size(127, 51);
            this.btnSalvarCurso.TabIndex = 2;
            this.btnSalvarCurso.Text = "Salvar";
            this.btnSalvarCurso.UseVisualStyleBackColor = true;
            this.btnSalvarCurso.Click += new System.EventHandler(this.btnSalvarCurso_Click);
            // 
            // btnEditarCurso
            // 
            this.btnEditarCurso.Location = new System.Drawing.Point(322, 335);
            this.btnEditarCurso.Name = "btnEditarCurso";
            this.btnEditarCurso.Size = new System.Drawing.Size(127, 51);
            this.btnEditarCurso.TabIndex = 3;
            this.btnEditarCurso.Text = "Editar";
            this.btnEditarCurso.UseVisualStyleBackColor = true;
            this.btnEditarCurso.Click += new System.EventHandler(this.btnEditarCurso_Click);
            // 
            // btnExcluirCurso
            // 
            this.btnExcluirCurso.Location = new System.Drawing.Point(626, 335);
            this.btnExcluirCurso.Name = "btnExcluirCurso";
            this.btnExcluirCurso.Size = new System.Drawing.Size(127, 51);
            this.btnExcluirCurso.TabIndex = 4;
            this.btnExcluirCurso.Text = "Excluir";
            this.btnExcluirCurso.UseVisualStyleBackColor = true;
            this.btnExcluirCurso.Click += new System.EventHandler(this.btnExcluirCurso_Click);
            // 
            // dataGridCurso
            // 
            this.dataGridCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCurso.Location = new System.Drawing.Point(30, 110);
            this.dataGridCurso.Name = "dataGridCurso";
            this.dataGridCurso.RowTemplate.Height = 24;
            this.dataGridCurso.Size = new System.Drawing.Size(723, 201);
            this.dataGridCurso.TabIndex = 5;
            // 
            // FormCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridCurso);
            this.Controls.Add(this.btnExcluirCurso);
            this.Controls.Add(this.btnEditarCurso);
            this.Controls.Add(this.btnSalvarCurso);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Name = "FormCurso";
            this.Text = "FormCurso";
            this.Load += new System.EventHandler(this.FormCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnSalvarCurso;
        private System.Windows.Forms.Button btnEditarCurso;
        private System.Windows.Forms.Button btnExcluirCurso;
        private System.Windows.Forms.DataGridView dataGridCurso;
    }
}