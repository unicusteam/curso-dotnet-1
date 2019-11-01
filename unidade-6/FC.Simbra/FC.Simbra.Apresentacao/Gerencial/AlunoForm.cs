using FC.Simbra.Aplicacao.Gerencial;
using FC.Simbra.Dominio.Gerencial;
using FC.Simbra.Dominio.Gerencial.Disciplinas;
using System;
using System.Windows.Forms;

namespace FC.Simbra.Apresentacao.Gerencial
{
    public partial class AlunoForm : Form
    {
        public Aluno Aluno
        {
            get { return aluno; }
            set { aluno = value; }
        }

        private Aluno aluno;
        private AlunoServico alunoServico;
        private CidadeServico cidadeServico;
        private DisciplinaServico disciplinaServico;

        public AlunoForm()
        {
            InitializeComponent();
            alunoServico = new AlunoServico();
            cidadeServico = new CidadeServico(alunoServico.Unidade);
            disciplinaServico = new DisciplinaServico(alunoServico.Unidade);
        }

        private Aluno ObterAluno()
        {
            return bsFormulario.DataSource as Aluno;
        }

        private Aluno ObterAlunoSelecionado()
        {
            return gridAlunos.CurrentRow.DataBoundItem as Aluno;
        }

        private void AtualizarGrid()
        {
            bsGrid.DataSource = alunoServico.ObterTodos();
        }

        private void AtualizarFormulario(Aluno aluno)
        {
            bsFormulario.DataSource = aluno;
            tbMatricula.ReadOnly = false;
            panelIdentificador.Visible = false;
        }

        private void Validar()
        {
            var mensagem = string.Join(Environment.NewLine, alunoServico.Validacoes);
            MessageBox.Show(mensagem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarFormulario(aluno);
            AtualizarGrid();

            foreach (var cidade in cidadeServico.ObterTodos())
            {
                cidadeComboBox.Items.Add(cidade);
            }

            foreach (var disciplina in disciplinaServico.ObterTodos())
            {
                disciplinaComboBox.Items.Add(disciplina);
            }
        }

        private void BtCadastrar_Click(object sender, EventArgs e)
        {
            if (alunoServico.Salvar(ObterAluno()))
            {
                AtualizarGrid();
                AtualizarFormulario(new Aluno());
            }
            else
            {
                Validar();
            }
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            if (!gridAlunos.CurrentRow.Selected)
            {
                return;
            }

            AtualizarFormulario(ObterAlunoSelecionado());
            panelIdentificador.Visible = true;
            tbMatricula.ReadOnly = true;
        }

        private void BtExluir_Click(object sender, EventArgs e)
        {
            if (!gridAlunos.CurrentRow.Selected)
            {
                return;
            }

            alunoServico.Excluir((ObterAlunoSelecionado()).Id);
            AtualizarGrid();
            AtualizarFormulario(new Aluno());
        }

        private void TxPesquisar_TextChanged(object sender, EventArgs e)
        {
            bsGrid.DataSource = alunoServico.ObterTodosPorNome(txPesquisar.Text);
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            AtualizarFormulario(new Aluno());
        }

        private void InserirDisciplinaButton_Click(object sender, EventArgs e)
        {
            Disciplina disciplina = disciplinaComboBox.SelectedItem as Disciplina;

            if (disciplina == null)
            {
                return;
            }

            ObterAluno().AdicionarDisciplina(disciplina);
            disciplinasBindingSource.ResetBindings(false);
            disciplinaComboBox.SelectedItem = null;
        }
    }
}
