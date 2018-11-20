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
    public partial class FormTipoParticipante : Form
    {
        ProjetoIntegradorEntities db = new ProjetoIntegradorEntities();
        private TipoParticipante tipoParticipante;

        public FormTipoParticipante()
        {
            InitializeComponent();
        }

        private void FormTipoParticipante_Load(object sender, EventArgs e)
        {
            dataGridTipoParticipante.ColumnCount = 2;
            dataGridTipoParticipante.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridTipoParticipante.MultiSelect = false;
            dataGridTipoParticipante.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            dataGridTipoParticipante.Columns[0].HeaderText = "Id Tipo Participante";
            dataGridTipoParticipante.Columns[0].DataPropertyName = "IdTipoParticipante";
            dataGridTipoParticipante.Columns[0].Width = 150;
            dataGridTipoParticipante.Columns[0].Name = "IdTipoParticipante";
            
            dataGridTipoParticipante.Columns[1].HeaderText = "Descrição da Participação";
            dataGridTipoParticipante.Columns[1].DataPropertyName = "Descricao";
            dataGridTipoParticipante.Columns[1].Width = 300;
            dataGridTipoParticipante.Columns[1].Name = "Descricao";
            CarregarGrid();
        }

        public void CarregarGrid()
        {
            var tipoParticipantes = from tipoParticipante in db.TipoParticipante select (new { tipoParticipante.IdTipoParticipante, tipoParticipante.Descricao });
            dataGridTipoParticipante.DataSource = tipoParticipantes.ToList();
        }

        private void btnSalvarTipoParticipante_Click(object sender, EventArgs e)
        {
            if (tipoParticipante == null)
                tipoParticipante = new TipoParticipante();
            int idPessoa = tipoParticipante.IdTipoParticipante > 0 ? tipoParticipante.IdTipoParticipante : 0;

            tipoParticipante.IdTipoParticipante = idPessoa;
            tipoParticipante.Descricao = txtDescricaoTipoParticipante.Text;
            string mensagem = "";

            if (tipoParticipante.IdTipoParticipante == 0)
            {
                db.TipoParticipante.Add(tipoParticipante);
                mensagem = "Tipo de Participante adicionado com sucesso!";

            }
            else
            {
                var obj = db.Entry(tipoParticipante);
                obj.Property(x => x.Descricao).IsModified = true;
                mensagem = "Nome do Tipo de Participante alterada com sucesso!";
            }
            db.SaveChanges();
            MessageBox.Show(mensagem);
            CarregarGrid();
            LimparCampos();
        }

        public void LimparCampos()
        {
            txtDescricaoTipoParticipante.Clear();
            tipoParticipante = null;
        }
    }

 }

