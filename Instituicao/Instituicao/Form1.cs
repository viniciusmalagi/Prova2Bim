using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instituicao
{
    public partial class Form1 : Form
    {
        List<Matricula> CadAlunos = new List<Matricula>();
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Deseja encerrar?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                Application.Exit();
        }

        private void cadastroAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadAl cadastro = new frmCadAl();
            cadastro.Show();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Aluno consultaAluno = new frm_Aluno();
            
            consultaAluno.dgv_MatAlunos.DataSource = null;
            consultaAluno.dgv_MatAlunos.DataSource = CadAlunos;
            consultaAluno.ShowDialog();
        }
    }
}
