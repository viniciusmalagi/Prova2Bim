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
    public partial class frmCadAl : Form
    {
        List<Matricula> CadAlunos = new List<Matricula>();
        public frmCadAl()
        {
            InitializeComponent();
        }

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            Matricula alunos = new Matricula();

            alunos.RA = int.Parse(txt_RA.Text);
            alunos.Nome = txt_Nome.Text;
            alunos.Curso1 = txt_1Curso.Text;
            alunos.Curso2 = txt_2Curso.Text;
            alunos.Inicio1 = data_1Curso.Text;
            alunos.Inicio2 = data_2Curso.Text;
            alunos.Status1 = txt_Sts1.Text;
            alunos.Status2 = txt_Sts2.Text;

            CadAlunos.Add(alunos);


        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            FrmConsulta consulta = new FrmConsulta();

            consulta.dgv_MatAlunos.DataSource = null;
            consulta.dgv_MatAlunos.DataSource = CadAlunos;
            consulta.ShowDialog();

            
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            txt_RA.Clear();
            txt_Nome.Clear();
            txt_1Curso.ResetText();
            txt_2Curso.ResetText();
            data_1Curso.ResetText();
            data_2Curso.ResetText();
            txt_Sts1.ResetText();
            txt_Sts2.ResetText();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
