namespace PI.WindownsFoms.Formularios
{
    partial class FormAluno
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
            this.components = new System.ComponentModel.Container();
            this.cboPessoa = new System.Windows.Forms.ComboBox();
            this.btnSalvarAluno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditarAluno = new System.Windows.Forms.Button();
            this.dataGridAluno = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.matriculaCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataMatriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaCursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPessoa
            // 
            this.cboPessoa.FormattingEnabled = true;
            this.cboPessoa.Location = new System.Drawing.Point(157, 26);
            this.cboPessoa.Name = "cboPessoa";
            this.cboPessoa.Size = new System.Drawing.Size(380, 24);
            this.cboPessoa.TabIndex = 0;
            this.cboPessoa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSalvarAluno
            // 
            this.btnSalvarAluno.Location = new System.Drawing.Point(27, 396);
            this.btnSalvarAluno.Name = "btnSalvarAluno";
            this.btnSalvarAluno.Size = new System.Drawing.Size(98, 52);
            this.btnSalvarAluno.TabIndex = 1;
            this.btnSalvarAluno.Text = "Salvar";
            this.btnSalvarAluno.UseVisualStyleBackColor = true;
            this.btnSalvarAluno.Click += new System.EventHandler(this.btnSalvarAluno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome da Pessoa:";
            // 
            // btnEditarAluno
            // 
            this.btnEditarAluno.Location = new System.Drawing.Point(157, 396);
            this.btnEditarAluno.Name = "btnEditarAluno";
            this.btnEditarAluno.Size = new System.Drawing.Size(98, 52);
            this.btnEditarAluno.TabIndex = 3;
            this.btnEditarAluno.Text = "Editar";
            this.btnEditarAluno.UseVisualStyleBackColor = true;
            // 
            // dataGridAluno
            // 
            this.dataGridAluno.AutoGenerateColumns = false;
            this.dataGridAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlunoDataGridViewTextBoxColumn,
            this.idCursoDataGridViewTextBoxColumn,
            this.dataMatriculaDataGridViewTextBoxColumn,
            this.alunoDataGridViewTextBoxColumn,
            this.cursoDataGridViewTextBoxColumn});
            this.dataGridAluno.DataSource = this.matriculaCursoBindingSource;
            this.dataGridAluno.Location = new System.Drawing.Point(27, 139);
            this.dataGridAluno.Name = "dataGridAluno";
            this.dataGridAluno.RowTemplate.Height = 24;
            this.dataGridAluno.Size = new System.Drawing.Size(1082, 230);
            this.dataGridAluno.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selecione o Curso:";
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(719, 26);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(380, 24);
            this.cboCurso.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Matricula:";
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.Location = new System.Drawing.Point(157, 82);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(154, 22);
            this.TxtMatricula.TabIndex = 8;
            // 
            // matriculaCursoBindingSource
            // 
            this.matriculaCursoBindingSource.DataSource = typeof(PI.Modelo.MatriculaCurso);
            // 
            // idAlunoDataGridViewTextBoxColumn
            // 
            this.idAlunoDataGridViewTextBoxColumn.DataPropertyName = "IdAluno";
            this.idAlunoDataGridViewTextBoxColumn.HeaderText = "IdAluno";
            this.idAlunoDataGridViewTextBoxColumn.Name = "idAlunoDataGridViewTextBoxColumn";
            // 
            // idCursoDataGridViewTextBoxColumn
            // 
            this.idCursoDataGridViewTextBoxColumn.DataPropertyName = "IdCurso";
            this.idCursoDataGridViewTextBoxColumn.HeaderText = "IdCurso";
            this.idCursoDataGridViewTextBoxColumn.Name = "idCursoDataGridViewTextBoxColumn";
            // 
            // dataMatriculaDataGridViewTextBoxColumn
            // 
            this.dataMatriculaDataGridViewTextBoxColumn.DataPropertyName = "DataMatricula";
            this.dataMatriculaDataGridViewTextBoxColumn.HeaderText = "DataMatricula";
            this.dataMatriculaDataGridViewTextBoxColumn.Name = "dataMatriculaDataGridViewTextBoxColumn";
            // 
            // alunoDataGridViewTextBoxColumn
            // 
            this.alunoDataGridViewTextBoxColumn.DataPropertyName = "Aluno";
            this.alunoDataGridViewTextBoxColumn.HeaderText = "Aluno";
            this.alunoDataGridViewTextBoxColumn.Name = "alunoDataGridViewTextBoxColumn";
            this.alunoDataGridViewTextBoxColumn.Width = 200;
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "Curso";
            this.cursoDataGridViewTextBoxColumn.HeaderText = "Curso";
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
            // 
            // FormAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 470);
            this.Controls.Add(this.TxtMatricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.dataGridAluno);
            this.Controls.Add(this.btnEditarAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvarAluno);
            this.Controls.Add(this.cboPessoa);
            this.Name = "FormAluno";
            this.Text = "FormAluno";
            this.Load += new System.EventHandler(this.FormAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaCursoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPessoa;
        private System.Windows.Forms.Button btnSalvarAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditarAluno;
        private System.Windows.Forms.DataGridView dataGridAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataMatriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource matriculaCursoBindingSource;
    }
}