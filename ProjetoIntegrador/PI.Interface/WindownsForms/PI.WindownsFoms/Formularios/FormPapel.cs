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
using System.Data.Entity;

namespace PI.WindownsFoms.Formularios
{
    public partial class FormPapel : Form
    {
        ProjetoIntegradorEntities db = new ProjetoIntegradorEntities();
        private Papel papel;
        private UsuarioPapel usuarioPapel;
        public FormPapel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormPapel_Load(object sender, EventArgs e)
        {
            dataGridPapel.ColumnCount = 2;
            dataGridPapel.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridPapel.MultiSelect = false;
            dataGridPapel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridPapel.Columns[0].HeaderText = "Código Papel";
            dataGridPapel.Columns[0].DataPropertyName = "IdPapel";
            dataGridPapel.Columns[0].Width = 150;
            dataGridPapel.Columns[0].Name = "IdPapel";

            dataGridPapel.Columns[1].HeaderText = "Descrição do Papel";
            dataGridPapel.Columns[1].DataPropertyName = "Descricao";
            dataGridPapel.Columns[1].Width = 300;
            dataGridPapel.Columns[1].Name = "Descricao";

            CarregarGrid();
        }

        public void CarregarGrid()
        {
            var papeis = from papel in db.Papel select (new { papel.IdPapel, papel.Descricao });
            dataGridPapel.DataSource = papeis.ToList();
        }

        private void btnSalvarPapel_Click(object sender, EventArgs e)
        {
            if (papel == null)
                papel = new Papel();

            int idPapel = papel.IdPapel > 0 ? papel.IdPapel : 0;

            papel.IdPapel = idPapel;
            papel.Descricao = txtDescricaoPapel.Text;
            string mensagem = "";

            if (papel.IdPapel == 0)
            {
                db.Papel.Add(papel);
                mensagem = "Papel registrado com sucesso";

            }
            else
            {
                var obj = db.Entry(papel);
                obj.Property(x => x.Descricao).IsModified = true;
                mensagem = "Papel alterado com sucesso!";
            }
            db.SaveChanges();
            MessageBox.Show(mensagem);
            CarregarGrid();
            LimparCampos();

        }

        public void LimparCampos()
        {
            txtDescricaoPapel.Clear();
            papel = null;
        }

        private void btnEditarPapel_Click(object sender, EventArgs e)
        {
            if (dataGridPapel.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridPapel.SelectedRows[0];
                int idPapel = (int)linha.Cells["idPapel"].Value;

                papel = db.Papel.Where(x => x.IdPapel == idPapel).FirstOrDefault();
                txtDescricaoPapel.Text = papel.Descricao;
            }
            else
            {
                MessageBox.Show("Selecione um Papel para Alterar!");
            }
        }

        private void btnExcluirPapel_Click(object sender, EventArgs e)
        {
            if (dataGridPapel.SelectedRows.Count > 0 && VerificarPapelUsuario())
            {
                DataGridViewRow linha = dataGridPapel.SelectedRows[0];
                int idPapel = (int)linha.Cells["IdPapel"].Value;

                papel = db.Papel.Where(x => x.IdPapel == idPapel).FirstOrDefault();
                db.Papel.Remove(papel);
                db.SaveChanges();

                MessageBox.Show("Papel excluido com Sucesso!");
                CarregarGrid();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Selecione um Papel para Excluir!");
            }
        }



    public bool VerificarPapelUsuario()
        {

            var papelusuarios = from papel in db.Papel
                           join usuariopapel in db.UsuarioPapel
                           on papel.IdPapel equals usuariopapel.IdUsuario

                           select (new { papel.IdPapel, usuariopapel.IdUsuario });
            if (papelusuarios.ToList() == null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Você não pode excluir um papel com Usuario Vinculado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
