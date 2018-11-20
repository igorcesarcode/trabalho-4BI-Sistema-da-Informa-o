using PI.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace PI.WindownsFoms.Formularios
{
    public partial class FormPessoa : Form
    {
        //Abrindo coneção com banco de dados.
        ProjetoIntegradorEntities db = new ProjetoIntegradorEntities();
        private Pessoa pessoa;

        public FormPessoa()
        {
            InitializeComponent();
        }

        private void FormPessoa_Load(object sender, EventArgs e)
        {
            dataGridPessoa.ColumnCount = 2;
            dataGridPessoa.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridPessoa.MultiSelect = false;
            dataGridPessoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    
            dataGridPessoa.Columns[0].HeaderText = "Código Papel";
            dataGridPessoa.Columns[0].DataPropertyName = "IdPessoa";
            dataGridPessoa.Columns[0].Width = 150;
            dataGridPessoa.Columns[0].Name = "IdPessoa";
                    
            dataGridPessoa.Columns[1].HeaderText = "Descrição do Papel";
            dataGridPessoa.Columns[1].DataPropertyName = "Nome";
            dataGridPessoa.Columns[1].Width = 300;
            dataGridPessoa.Columns[1].Name = "Nome";

            CarregarGrid();
        }

        public void CarregarGrid()
        {
            //"pessoas" variavel local, para poder maipular objeto "pessoa" dentro do grid e text.
            // "pessoa" é objeto do banco de dados que eu definir no public class.
            //"db.Pessoa" é a coneção com o banco que foi criado altomaticamente.

            var pessoas  = from pessoa in db.Pessoa select (new { pessoa.IdPessoa, pessoa.Nome });
            dataGridPessoa.DataSource = pessoas.ToList();
        }

    private void btnSalvarPessoa_Click(object sender, EventArgs e)
        {
            if (pessoa == null)
                pessoa = new Pessoa();
            //Definindo um id local para selecionar as instacias do objeto
            int idPessoa = pessoa.IdPessoa > 0 ? pessoa.IdPessoa : 0;

            pessoa.IdPessoa = idPessoa;
            pessoa.Nome = txtDescricaoPessoa.Text;
            string mensagem = "";

            if (pessoa.IdPessoa == 0)
            {
                db.Pessoa.Add(pessoa);
                mensagem = "Pessoa adicionada com sucesso!";

            }
            else
            {
                var obj = db.Entry(pessoa);
                obj.Property(x => x.Nome).IsModified = true;
                mensagem = "Nome da Pessoa alterada com sucesso!";
            }
            db.SaveChanges();
            MessageBox.Show(mensagem);
            CarregarGrid();
            LimparCampos();

        }

        public void LimparCampos()
        {
            txtDescricaoPessoa.Clear();
            pessoa = null;
        }

        private void btnEditarPessoa_Click(object sender, EventArgs e)
        {
            if (dataGridPessoa.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridPessoa.SelectedRows[0];
                int idPessoa = (int)linha.Cells["idPessoa"].Value;

                pessoa = db.Pessoa.Where(x => x.IdPessoa == idPessoa).FirstOrDefault();
                txtDescricaoPessoa.Text = pessoa.Nome;
            }
            else
            {
                MessageBox.Show("Selecione um Papel para Alterar!");
            }
        }

        private void btnExcluirPessoa_Click(object sender, EventArgs e)
        {
            if (dataGridPessoa.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridPessoa.SelectedRows[0];
                int idPessoa = (int)linha.Cells["IdPessoa"].Value;

                pessoa = db.Pessoa.Where(x => x.IdPessoa == idPessoa).FirstOrDefault();
                db.Pessoa.Remove(pessoa);
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
    }
}
