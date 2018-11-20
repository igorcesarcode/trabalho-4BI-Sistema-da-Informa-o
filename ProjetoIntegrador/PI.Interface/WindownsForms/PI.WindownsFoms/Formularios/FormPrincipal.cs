using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI.WindownsFoms.Formularios
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void listaDePapeisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPapel formPapel = new FormPapel();
            formPapel.MdiParent = this;
            formPapel.Show();
        }

        private void cadastrarPessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPessoa formPessoa = new FormPessoa();
            formPessoa.MdiParent = this;
            formPessoa.Show();
        }

        private void cadastrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario();
            formUsuario.MdiParent = this;
            formUsuario.Show();
        }

        private void vincularPapéisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarioPapel formUsuarioPapel = new FormUsuarioPapel();
            formUsuarioPapel.MdiParent = this;
            formUsuarioPapel.Show();
        }

        private void listaDeProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProjeto formProjeto = new FormProjeto();
            formProjeto.MdiParent = this;
            formProjeto.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listaDeProjetosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormListaProjeto formListaProjeto = new FormListaProjeto();
            formListaProjeto.MdiParent = this;
            formListaProjeto.Show();
        }

        private void cadastrarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCurso formCurso = new FormCurso();
            formCurso.MdiParent = this;
            formCurso.Show();
        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAluno formAluno = new FormAluno();
            formAluno.MdiParent = this;
            formAluno.Show();
        }

        private void novoTipoDeParticipanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoParticipante formTipoParticipante = new FormTipoParticipante();
            formTipoParticipante.MdiParent = this;
            formTipoParticipante.Show();
        }
    }
}
