using Dls.DomainDrivenDesign.Aplicacao;
using Dls.DomainDrivenDesign.Dominio.Gerencial.Alunos;
using System.Windows.Forms;

namespace Dls.DomainDrivenDesign.Apresentacao.Wf
{
    public partial class Form1 : Form
    {
        private AlunoServico alunoServico;

        public Form1()
        {
            InitializeComponent();
            alunoServico = new AlunoServico();
            alunosBindingSource.DataSource = alunoServico.ObterTodos();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            alunosBindingSource.DataSource = alunoServico.ObterTodosPorNome(text.Text);
        }
    }
}
