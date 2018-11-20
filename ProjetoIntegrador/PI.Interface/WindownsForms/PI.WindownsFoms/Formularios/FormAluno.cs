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
    public partial class FormAluno : Form
    {
        ProjetoIntegradorEntities db = new ProjetoIntegradorEntities();
        private Aluno aluno;
        private MatriculaCurso matriculaCurso;
        
        
        public FormAluno()
        {
            InitializeComponent();
        }

        private void FormAluno_Load(object sender, EventArgs e)
        {

            cboPessoa.DataSource = db.Pessoa.ToList(); //define a fonte de dados.
            cboPessoa.DisplayMember = "Nome"; // define qual dado vai ser carregado na cobobox.
            cboPessoa.ValueMember = "IdPessoa"; //define que a classificação do combobox vai ser atraz do seu id "IdPapel". 

            cboCurso.DataSource = db.Curso.ToList();
            cboCurso.DisplayMember = "Descricao";
            cboCurso.ValueMember = "IdCurso";
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarAluno_Click(object sender, EventArgs e)
        {
            if (aluno == null && matriculaCurso == null)
            {
                aluno = new Aluno();
                matriculaCurso = new MatriculaCurso();
            }
            aluno.IdAluno = (int)cboPessoa.SelectedValue;
            matriculaCurso.IdAluno = (int)cboPessoa.SelectedValue;
            matriculaCurso.IdCurso = (int)cboCurso.SelectedValue;
            matriculaCurso.DataMatricula = DateTime.Now;

            string mensagem = "";
            if (VerificarAlunoPessoa(aluno.IdAluno))
            {
                MessageBox.Show("Este pessoa já está vinculado há alguma matricula!");
            }
            else
            {
                db.Aluno.Add(aluno);
                db.SaveChanges();
                
                mensagem = "Vinculação de matricula realizada com sucesso!";
                db.MatriculaCurso.Add(matriculaCurso);
                db.SaveChanges();

                MessageBox.Show(mensagem);
                LimparCampos();

            }

        }

        public void CarregarGrid()
        {
            //var alunosMatricula = 
          //      from aluno in db.Aluno
          //      join matriculaCurso in db.MatriculaCurso
          //          on 
         //       select (new { aluno.IdAluno, aluno.Matricula });
          //  dataGridAluno.DataSource = alunosMatricula.ToList();
        }

        public void LimparCampos()
        {
            cboPessoa.SelectedIndex = 0;
            cboCurso.SelectedIndex = 0;
            aluno = null;
            matriculaCurso = null;
        }
        private bool VerificarAlunoPessoa(int idAluno)
        {

            //Se ja existir registro para um usuario para um papel , quer dizer que o usuario ja estar vinculado há algum papel.
            return db.Aluno.Where(x => x.IdAluno == idAluno).Count() > 0 ? true : false; //Caso ainda não tenha nenhuma vinculação ele retorna "false".
        }

    }
}
