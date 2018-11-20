using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI.Modelo;

namespace PI.WindownsFoms.Formularios
{
    public partial class FormCurso : Form
    {
        ProjetoIntegradorEntities db = new ProjetoIntegradorEntities();
        private Curso curso;


        public FormCurso()
        {
            InitializeComponent();
        }

        private void FormCurso_Load(object sender, EventArgs e)
        {
            dataGridCurso.ColumnCount = 2;
            dataGridCurso.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridCurso.MultiSelect = false;
            dataGridCurso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            dataGridCurso.Columns[0].HeaderText = "ID do Curso";
            dataGridCurso.Columns[0].DataPropertyName = "IdCurso";
            dataGridCurso.Columns[0].Width = 150;
            dataGridCurso.Columns[0].Name = "IdCurso";
            
            dataGridCurso.Columns[1].HeaderText = "Descrição do curso";
            dataGridCurso.Columns[1].DataPropertyName = "Descricao";
            dataGridCurso.Columns[1].Width = 300;
            dataGridCurso.Columns[1].Name = "Descricao";

            CarregarGrid();
        }

        public void CarregarGrid()
        {
            var cursos = from curso in db.Curso select (new { curso.IdCurso, curso.Descricao });
            dataGridCurso.DataSource = cursos.ToList();
        }

        private void btnSalvarCurso_Click(object sender, EventArgs e)
        {
            if (curso == null)
                curso = new Curso();
            int idPessoa = curso.IdCurso > 0 ? curso.IdCurso : 0;

            curso.IdCurso = idPessoa;
            curso.Descricao = txtDescricao.Text;
            string mensagem = "";

            if (curso.IdCurso == 0)
            {
                db.Curso.Add(curso);
                mensagem = "Curso adicionada com sucesso!";

            }
            else
            {
                var obj = db.Entry(curso);
                obj.Property(x => x.Descricao).IsModified = true;
                mensagem = "Nome do Curso e Descrição alterada com sucesso!";
            }
            db.SaveChanges();
            MessageBox.Show(mensagem);
            CarregarGrid();
            LimparCampos();
        }

        public void LimparCampos()
        {
            txtDescricao.Clear();
            curso = null;
        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            if (dataGridCurso.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridCurso.SelectedRows[0];
                int idCurso = (int)linha.Cells["idCurso"].Value;

                curso = db.Curso.Where(x => x.IdCurso == idCurso).FirstOrDefault();
                txtDescricao.Text = curso.Descricao;
            }
            else
            {
                MessageBox.Show("Selecione um Curso para Alterar!");
            }
        }

        private void btnExcluirCurso_Click(object sender, EventArgs e)
        {
            if (dataGridCurso.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridCurso.SelectedRows[0];
                int idCurso = (int)linha.Cells["IdCurso"].Value;

                curso = db.Curso.Where(x => x.IdCurso == idCurso).FirstOrDefault();
                db.Curso.Remove(curso);
                db.SaveChanges();

                MessageBox.Show("Curso excluido com Sucesso!");
                CarregarGrid();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Selecione um Curso para Excluir!");
            }
        }
    }
}
