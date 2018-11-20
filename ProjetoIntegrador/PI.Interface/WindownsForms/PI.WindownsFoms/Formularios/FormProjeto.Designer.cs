namespace PI.WindownsFoms.Formularios
{
    partial class FormProjeto
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
            this.btnSalvarEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTituloProjeto = new System.Windows.Forms.TextBox();
            this.dtgAlunos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAdicionarUsuarioProjeto = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vProjetoAlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vProjetoAlunoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProjetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoParticipanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoParticipanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProjetoAlunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProjetoAlunoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvarEditar
            // 
            this.btnSalvarEditar.Location = new System.Drawing.Point(27, 346);
            this.btnSalvarEditar.Name = "btnSalvarEditar";
            this.btnSalvarEditar.Size = new System.Drawing.Size(99, 40);
            this.btnSalvarEditar.TabIndex = 0;
            this.btnSalvarEditar.Text = "Salvar";
            this.btnSalvarEditar.UseVisualStyleBackColor = true;
            this.btnSalvarEditar.Click += new System.EventHandler(this.btnSalvarEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Novo Projeto:";
            // 
            // txtTituloProjeto
            // 
            this.txtTituloProjeto.Location = new System.Drawing.Point(122, 16);
            this.txtTituloProjeto.Name = "txtTituloProjeto";
            this.txtTituloProjeto.Size = new System.Drawing.Size(684, 22);
            this.txtTituloProjeto.TabIndex = 2;
            // 
            // dtgAlunos
            // 
            this.dtgAlunos.AutoGenerateColumns = false;
            this.dtgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlunoDataGridViewTextBoxColumn,
            this.idProjetoDataGridViewTextBoxColumn,
            this.idTipoParticipanteDataGridViewTextBoxColumn,
            this.dataRegistroDataGridViewTextBoxColumn,
            this.nomeAlunoDataGridViewTextBoxColumn,
            this.tipoParticipanteDataGridViewTextBoxColumn});
            this.dtgAlunos.DataSource = this.vProjetoAlunoBindingSource1;
            this.dtgAlunos.Location = new System.Drawing.Point(27, 140);
            this.dtgAlunos.Name = "dtgAlunos";
            this.dtgAlunos.RowTemplate.Height = 24;
            this.dtgAlunos.Size = new System.Drawing.Size(778, 166);
            this.dtgAlunos.TabIndex = 10;
            this.dtgAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAlunos_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lista de Usuarios no Projeto";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // btnAdicionarUsuarioProjeto
            // 
            this.btnAdicionarUsuarioProjeto.Location = new System.Drawing.Point(661, 80);
            this.btnAdicionarUsuarioProjeto.Name = "btnAdicionarUsuarioProjeto";
            this.btnAdicionarUsuarioProjeto.Size = new System.Drawing.Size(144, 54);
            this.btnAdicionarUsuarioProjeto.TabIndex = 13;
            this.btnAdicionarUsuarioProjeto.Text = "Adicionar/Remover Usuario ao Projeto";
            this.btnAdicionarUsuarioProjeto.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(316, 101);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(277, 24);
            this.comboBox2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo de Participante";
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataSource = typeof(PI.Modelo.Aluno);
            // 
            // vProjetoAlunoBindingSource
            // 
            this.vProjetoAlunoBindingSource.DataSource = typeof(PI.Modelo.vProjetoAluno);
            // 
            // vProjetoAlunoBindingSource1
            // 
            this.vProjetoAlunoBindingSource1.DataSource = typeof(PI.Modelo.vProjetoAluno);
            // 
            // idAlunoDataGridViewTextBoxColumn
            // 
            this.idAlunoDataGridViewTextBoxColumn.DataPropertyName = "IdAluno";
            this.idAlunoDataGridViewTextBoxColumn.HeaderText = "IdAluno";
            this.idAlunoDataGridViewTextBoxColumn.Name = "idAlunoDataGridViewTextBoxColumn";
            // 
            // idProjetoDataGridViewTextBoxColumn
            // 
            this.idProjetoDataGridViewTextBoxColumn.DataPropertyName = "IdProjeto";
            this.idProjetoDataGridViewTextBoxColumn.HeaderText = "IdProjeto";
            this.idProjetoDataGridViewTextBoxColumn.Name = "idProjetoDataGridViewTextBoxColumn";
            // 
            // idTipoParticipanteDataGridViewTextBoxColumn
            // 
            this.idTipoParticipanteDataGridViewTextBoxColumn.DataPropertyName = "IdTipoParticipante";
            this.idTipoParticipanteDataGridViewTextBoxColumn.HeaderText = "IdTipoParticipante";
            this.idTipoParticipanteDataGridViewTextBoxColumn.Name = "idTipoParticipanteDataGridViewTextBoxColumn";
            // 
            // dataRegistroDataGridViewTextBoxColumn
            // 
            this.dataRegistroDataGridViewTextBoxColumn.DataPropertyName = "DataRegistro";
            this.dataRegistroDataGridViewTextBoxColumn.HeaderText = "DataRegistro";
            this.dataRegistroDataGridViewTextBoxColumn.Name = "dataRegistroDataGridViewTextBoxColumn";
            // 
            // nomeAlunoDataGridViewTextBoxColumn
            // 
            this.nomeAlunoDataGridViewTextBoxColumn.DataPropertyName = "NomeAluno";
            this.nomeAlunoDataGridViewTextBoxColumn.HeaderText = "NomeAluno";
            this.nomeAlunoDataGridViewTextBoxColumn.Name = "nomeAlunoDataGridViewTextBoxColumn";
            // 
            // tipoParticipanteDataGridViewTextBoxColumn
            // 
            this.tipoParticipanteDataGridViewTextBoxColumn.DataPropertyName = "TipoParticipante";
            this.tipoParticipanteDataGridViewTextBoxColumn.HeaderText = "TipoParticipante";
            this.tipoParticipanteDataGridViewTextBoxColumn.Name = "tipoParticipanteDataGridViewTextBoxColumn";
            // 
            // FormProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 435);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdicionarUsuarioProjeto);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgAlunos);
            this.Controls.Add(this.txtTituloProjeto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvarEditar);
            this.Name = "FormProjeto";
            this.Text = "Editar Projeto";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProjetoAlunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProjetoAlunoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTituloProjeto;
        private System.Windows.Forms.DataGridView dtgAlunos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAdicionarUsuarioProjeto;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource vProjetoAlunoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProjetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoParticipanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoParticipanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vProjetoAlunoBindingSource1;
    }
}