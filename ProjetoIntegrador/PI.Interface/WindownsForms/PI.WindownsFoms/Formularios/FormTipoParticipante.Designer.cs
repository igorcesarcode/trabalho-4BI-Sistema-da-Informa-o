namespace PI.WindownsFoms.Formularios
{
    partial class FormTipoParticipante
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
            this.dataGridTipoParticipante = new System.Windows.Forms.DataGridView();
            this.btnExcluirCurso = new System.Windows.Forms.Button();
            this.btnEditarCurso = new System.Windows.Forms.Button();
            this.btnSalvarTipoParticipante = new System.Windows.Forms.Button();
            this.txtDescricaoTipoParticipante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTipoParticipante)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTipoParticipante
            // 
            this.dataGridTipoParticipante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTipoParticipante.Location = new System.Drawing.Point(41, 91);
            this.dataGridTipoParticipante.Name = "dataGridTipoParticipante";
            this.dataGridTipoParticipante.RowTemplate.Height = 24;
            this.dataGridTipoParticipante.Size = new System.Drawing.Size(723, 201);
            this.dataGridTipoParticipante.TabIndex = 11;
            // 
            // btnExcluirCurso
            // 
            this.btnExcluirCurso.Location = new System.Drawing.Point(637, 317);
            this.btnExcluirCurso.Name = "btnExcluirCurso";
            this.btnExcluirCurso.Size = new System.Drawing.Size(127, 51);
            this.btnExcluirCurso.TabIndex = 10;
            this.btnExcluirCurso.Text = "Excluir";
            this.btnExcluirCurso.UseVisualStyleBackColor = true;
            // 
            // btnEditarCurso
            // 
            this.btnEditarCurso.Location = new System.Drawing.Point(333, 317);
            this.btnEditarCurso.Name = "btnEditarCurso";
            this.btnEditarCurso.Size = new System.Drawing.Size(127, 51);
            this.btnEditarCurso.TabIndex = 9;
            this.btnEditarCurso.Text = "Editar";
            this.btnEditarCurso.UseVisualStyleBackColor = true;
            // 
            // btnSalvarTipoParticipante
            // 
            this.btnSalvarTipoParticipante.Location = new System.Drawing.Point(41, 317);
            this.btnSalvarTipoParticipante.Name = "btnSalvarTipoParticipante";
            this.btnSalvarTipoParticipante.Size = new System.Drawing.Size(127, 51);
            this.btnSalvarTipoParticipante.TabIndex = 8;
            this.btnSalvarTipoParticipante.Text = "Salvar";
            this.btnSalvarTipoParticipante.UseVisualStyleBackColor = true;
            this.btnSalvarTipoParticipante.Click += new System.EventHandler(this.btnSalvarTipoParticipante_Click);
            // 
            // txtDescricaoTipoParticipante
            // 
            this.txtDescricaoTipoParticipante.Location = new System.Drawing.Point(244, 18);
            this.txtDescricaoTipoParticipante.Name = "txtDescricaoTipoParticipante";
            this.txtDescricaoTipoParticipante.Size = new System.Drawing.Size(520, 22);
            this.txtDescricaoTipoParticipante.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome do Tipo de Participante:";
            // 
            // FormTipoParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 401);
            this.Controls.Add(this.dataGridTipoParticipante);
            this.Controls.Add(this.btnExcluirCurso);
            this.Controls.Add(this.btnEditarCurso);
            this.Controls.Add(this.btnSalvarTipoParticipante);
            this.Controls.Add(this.txtDescricaoTipoParticipante);
            this.Controls.Add(this.label1);
            this.Name = "FormTipoParticipante";
            this.Text = "FormTipoParticipante";
            this.Load += new System.EventHandler(this.FormTipoParticipante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTipoParticipante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTipoParticipante;
        private System.Windows.Forms.Button btnExcluirCurso;
        private System.Windows.Forms.Button btnEditarCurso;
        private System.Windows.Forms.Button btnSalvarTipoParticipante;
        private System.Windows.Forms.TextBox txtDescricaoTipoParticipante;
        private System.Windows.Forms.Label label1;
    }
}