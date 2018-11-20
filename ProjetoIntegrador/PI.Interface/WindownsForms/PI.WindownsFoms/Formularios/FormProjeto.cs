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
    public partial class FormProjeto : Form
    {
        PI.Modelo.Projeto PJ = new Modelo.Projeto();

        public FormProjeto()
        {
            InitializeComponent();

            //PJ = ProjetoPassadoComoParametroParaATela;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarEditar_Click(object sender, EventArgs e)
        {
            
            //PJ.Descricao = txtDescricao.Text;

            foreach (PI.Modelo.vProjetoAluno a in dtgAlunos.Rows)
            {
                PI.Modelo.ProjetoAluno Al = new Modelo.ProjetoAluno();
                Al.IdAluno = a.IdAluno;
                Al.IdProjeto = PJ.IdProjeto;
                Al.IdTipoParticipante = a.IdTipoParticipante;
                Al.DataRegistro = DateTime.Now;

                PJ.ProjetoAluno.Add(Al);
            }

            //Chamar o método pra salvar o PJ
        }

        private void dtgAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
