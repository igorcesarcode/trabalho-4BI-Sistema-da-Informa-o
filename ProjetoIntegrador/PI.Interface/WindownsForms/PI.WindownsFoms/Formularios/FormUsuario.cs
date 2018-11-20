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
using System.Security.Cryptography;

namespace PI.WindownsFoms.Formularios
{
    public partial class FormUsuario : Form
    {
        ProjetoIntegradorEntities db = new ProjetoIntegradorEntities();
        private Usuario usuario;

        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {

            //Caregamento de Pessoas do Banco de Dados na minha ComboBox.

            //Carrega o traz a lista de pessoas do banco de dados.
            cboPessoa.DataSource = db.Pessoa.ToList();

            //Define qual campo vai ser mostrado no combox -- No casso estar definido como "Nome".
            cboPessoa.DisplayMember = "Nome";

            //Define qual vai ser o evento de manipulação da pessoa -- No caso vai ser manipulado pelo id que é "IdPessoa".
            cboPessoa.ValueMember = "IdPessoa";


            //Define o numero de colunas
            dataGridViewUsuario.ColumnCount = 4;

            dataGridViewUsuario.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewUsuario.MultiSelect = false;
            dataGridViewUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Primeira Coluna
            dataGridViewUsuario.Columns[0].HeaderText = "Codigo";
            dataGridViewUsuario.Columns[0].DataPropertyName = "IdUsuario"; //Nome da linha no Banco de Dados
            dataGridViewUsuario.Columns[0].Name = "IdUsuario";
            dataGridViewUsuario.Columns[0].Width = 50;

            //Segunda Coluna
            dataGridViewUsuario.Columns[1].HeaderText = "Pessoa";
            dataGridViewUsuario.Columns[1].DataPropertyName = "Nome"; //Nome da linha no Banco de Dados
            dataGridViewUsuario.Columns[1].Name = "Nome";
            dataGridViewUsuario.Columns[1].Width = 150;

            //Terceira Coluna
            dataGridViewUsuario.Columns[2].HeaderText = "Usuário";
            dataGridViewUsuario.Columns[2].DataPropertyName = "Usuario1"; //Nome da linha no Banco de Dados
            dataGridViewUsuario.Columns[2].Name = "Usuario1";
            dataGridViewUsuario.Columns[2].Width = 200;

            //Quarta Coluna
            dataGridViewUsuario.Columns[3].HeaderText = "Senha";
            dataGridViewUsuario.Columns[3].DataPropertyName = "Senha";//Nome da linha no Banco de Dados
            dataGridViewUsuario.Columns[3].Name = "Senha";
            dataGridViewUsuario.Columns[3].Width = 150;

            CarregarGrid();

        }

        public void CarregarGrid()
        {

            // A variavel local "usuarios" guarda a consulta no banco de dados
            var usuarios = from usuario in db.Usuario
                           join pessoa in db.Pessoa
                           on usuario.IdPessoa equals pessoa.IdPessoa

                           select (new { usuario.IdUsuario, pessoa.Nome, usuario.Usuario1, usuario.Senha });

            //Carregando o DataSourse com a variavel local usuarios e dando um ToLista(), para trazer a lista da consulta.
            dataGridViewUsuario.DataSource = usuarios.ToList();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (usuario == null)
                usuario = new Usuario();

            int idUsuario = usuario.IdUsuario > 0 ? usuario.IdUsuario : 0;


            usuario.IdUsuario = idUsuario;
            usuario.Usuario1 = txtUsuario.Text;
            usuario.Senha = CriptografarMD5(txtSenha.Text); //Antes de salvar ele Criptografa a senha em MD5
            usuario.IdPessoa = (int)cboPessoa.SelectedValue; //Pega o Id do usuario com base opção selecionada.

            string mensagem = ""; 
            if (VerificarSeUsuarioRegistrado(usuario.Usuario1))
            {
                MessageBox.Show("Esse usuario já estar sendo ultilizado! Selecione outro.");
            }
            else
            {
                if (usuario.IdUsuario == 0)
                {
                    db.Usuario.Add(usuario);
                    mensagem = "Usuário registrado com sucesso!";
                }
                else
                {
                    var obj = db.Entry(usuario);
                    obj.Property(x => x.Usuario1).IsModified = true;
                    obj.Property(x => x.Senha).IsModified = true;
                    mensagem = "Usuário alterado com sucesso!";
                }

                db.SaveChanges();
                MessageBox.Show(mensagem);
                LimparCampos();
                CarregarGrid();

            }

        }

        public string CriptografarMD5(string senha)
        {
            MD5 md5 = MD5.Create();
            byte[] senhaBytes = Encoding.ASCII.GetBytes(senha);
            byte[] hash = md5.ComputeHash(senhaBytes);
            StringBuilder sb = new StringBuilder();
            for (int i=0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private bool VerificarSeUsuarioRegistrado(string usuario)
        {
            return db.Usuario.Where(x => x.Usuario1 == usuario).Count() > 0 ? true : false;
        }

        private void LimparCampos()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            cboPessoa.SelectedIndex = 0;
            usuario = null;
            lblUsuario.Text = "Usuário:";
            lblSenha.Text = "Senha:";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuario.SelectedRows.Count > 0)
            {
                int idUsuario = (int)dataGridViewUsuario.CurrentRow.Cells[0].Value; //Pega o Id do usuario com base na linha celecionada.

                usuario = db.Usuario.Where(x => x.IdUsuario == idUsuario).FirstOrDefault();


                cboPessoa.SelectedValue = usuario.IdPessoa;
                txtUsuario.Text = usuario.Usuario1;
                lblUsuario.Text = "Digite Novo Usuário:";
                lblSenha.Text = "Digite Nova Senha:";
            }
            else
            {
                MessageBox.Show("Selecione um registro para alterar!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuario.SelectedRows.Count > 0)
            {
                //Se a pessoa confirmar que realmente quer excluir o programa vai excluir o registro!
                if (MessageBox.Show("Deseja realmnete excluir esse Usuário? ", "Confimação de Exclução" , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idUsuario = (int)dataGridViewUsuario.CurrentRow.Cells[0].Value; //Pega o Id do usuario com base na linha celecionada.

                    usuario = db.Usuario.Where(x => x.IdUsuario == idUsuario).FirstOrDefault();

                    db.Usuario.Remove(usuario);
                    db.SaveChanges();

                    MessageBox.Show("Usuário excluido com sucesso!");
                    CarregarGrid();
                    LimparCampos();

                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para alterar!");
            }
        }
    }
}
