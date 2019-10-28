using FC.Simbra.Apresentacao.Gerencial;
using FC.Simbra.Dominio.Gerencial;
using System;
using System.Windows.Forms;

namespace FC.Simbra.Apresentacao
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlunoForm mainForm = new AlunoForm();
            mainForm.Aluno = new Aluno();
            mainForm.Show();
        }
    }
}
