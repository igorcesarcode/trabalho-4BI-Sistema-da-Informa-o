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
    public partial class FormUsuarioPapel : Form
    {
        ProjetoIntegradorEntities db = new ProjetoIntegradorEntities();
        private UsuarioPapel usuarioPapel;
        public FormUsuarioPapel()
        {
            InitializeComponent();
        }

        private void FormUsuarioPapel_Load(object sender, EventArgs e)  //Função iniciada no carregamento do Form
        {
            //Carrega o cobobox papel com as informação da tabela papel.
            cboPapel.DataSource = db.Papel.ToList(); //define a fonte de dados.
            cboPapel.DisplayMember = "Descricao"; // define qual dado vai ser carregado na cobobox.
            cboPapel.ValueMember = "IdPapel"; //define que a classificação do combobox vai ser atraz do seu id "IdPapel". 

            //Carrega o cobobox usuario com as informação da tabela usuario.
            cboUsuario.DataSource = db.Usuario.ToList();
            cboUsuario.DisplayMember = "Usuario1";
            cboUsuario.ValueMember = "IdUsuario";


            //Define o numero de colunas
            gridViewUsuarioPapel.ColumnCount = 6;

            gridViewUsuarioPapel.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridViewUsuarioPapel.MultiSelect = false;
            gridViewUsuarioPapel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Primeira Coluna
            gridViewUsuarioPapel.Columns[0].HeaderText = "Codigo Papel";
            gridViewUsuarioPapel.Columns[0].DataPropertyName = "IdPapel";
            gridViewUsuarioPapel.Columns[0].Name = "IdPapel";
            gridViewUsuarioPapel.Columns[0].Width = 50;

            gridViewUsuarioPapel.Columns[1].HeaderText = "Codigo Usuário";
            gridViewUsuarioPapel.Columns[1].DataPropertyName = "IdUsuario";
            gridViewUsuarioPapel.Columns[1].Name = "IdUsuario";
            gridViewUsuarioPapel.Columns[1].Width = 50;

            gridViewUsuarioPapel.Columns[2].HeaderText = "Papel";
            gridViewUsuarioPapel.Columns[2].DataPropertyName = "Descricao";
            gridViewUsuarioPapel.Columns[2].Name = "Drescricao";
            gridViewUsuarioPapel.Columns[2].Width = 150;

            gridViewUsuarioPapel.Columns[3].HeaderText = "Usuario";
            gridViewUsuarioPapel.Columns[3].DataPropertyName = "Usuario1";
            gridViewUsuarioPapel.Columns[3].Name = "Usuario1";
            gridViewUsuarioPapel.Columns[3].Width = 150;


            gridViewUsuarioPapel.Columns[4].HeaderText = "Data Início";
            gridViewUsuarioPapel.Columns[4].DataPropertyName = "DataInicioVigencia";
            gridViewUsuarioPapel.Columns[4].Name = "DataInicioVigencia";
            gridViewUsuarioPapel.Columns[4].Width = 100;

            gridViewUsuarioPapel.Columns[5].HeaderText = "Data Fim";
            gridViewUsuarioPapel.Columns[5].DataPropertyName = "DataFimVigencia";
            gridViewUsuarioPapel.Columns[5].Name = "DataFimVigencia";
            gridViewUsuarioPapel.Columns[5].Width = 100;

            CarregarGrid();
        }

        public void CarregarGrid()
        {
            var papeisUsuario =
                from papel in db.Papel
                join usuariopapel in db.UsuarioPapel
                    on papel.IdPapel equals usuariopapel.IdPapel
                join usuario in db.Usuario
                    on usuariopapel.IdUsuario equals usuario.IdUsuario
                select (new
                        {
                            papel.IdPapel,
                            usuario.IdUsuario,
                            papel.Descricao,
                            usuario.Usuario1,
                            usuariopapel.DataInicioVigencia,
                            usuariopapel.DataFimVigencia

                        });

            gridViewUsuarioPapel.DataSource = papeisUsuario.ToList();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (usuarioPapel == null)
                usuarioPapel = new UsuarioPapel();

            usuarioPapel.IdUsuario = (int)cboUsuario.SelectedValue;
            usuarioPapel.IdPapel = (int)cboPapel.SelectedValue;
            usuarioPapel.DataInicioVigencia = DateTime.Now;

            string mensagem = "";
            if (VerificarPapelUsuario(usuarioPapel.IdUsuario,usuarioPapel.IdPapel))
            {
                MessageBox.Show("Este papel já está vinculado ao usuário selecionado!");
            }
            else
            {
                db.UsuarioPapel.Add(usuarioPapel);
                mensagem = "Vinculação de papel realizada com sucesso!";

                db.SaveChanges();

                MessageBox.Show(mensagem);
                CarregarGrid();
                LimparCampos();

            }
        }

        private bool VerificarPapelUsuario(int idUsuario, int idPapel)
        {

            //Se ja existir registro para um usuario para um papel , quer dizer que o usuario ja estar vinculado há algum papel.
            return db.UsuarioPapel.Where(x => x.IdUsuario == idUsuario 
            && x.IdPapel == idPapel).Count() > 0 ? true : false; //Caso ainda não tenha nenhuma vinculação ele retorna "false".
        }

        public void LimparCampos()
        {
            cboPapel.SelectedIndex = 0;
            cboUsuario.SelectedIndex = 0;
            usuarioPapel = null;
        }

        private void btnAtivarDesativar_Click(object sender, EventArgs e)
        {
            
            if (gridViewUsuarioPapel.SelectedRows.Count > 0)
            {
                int idPapel = (int)gridViewUsuarioPapel.CurrentRow.Cells[0].Value;
                int idUsuario = (int)gridViewUsuarioPapel.CurrentRow.Cells[1].Value;

                usuarioPapel = db.UsuarioPapel.Where(x => x.IdPapel == idPapel
                && x.IdUsuario == idUsuario).FirstOrDefault();

                usuarioPapel.DataFimVigencia = usuarioPapel.DataFimVigencia == null ? DateTime.Now
                    : usuarioPapel.DataFimVigencia = null;

                var obj = db.Entry(usuarioPapel);
                obj.Property(x => x.DataFimVigencia).IsModified = true;

                db.SaveChanges();

                MessageBox.Show("Usuário Alterado com sucesso");
                CarregarGrid();
                LimparCampos();

            }
            else
            {
                MessageBox.Show("Selecione um registro para Ativar / Desativar");
            }
        }
    }

}
