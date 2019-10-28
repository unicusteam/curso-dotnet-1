using FC.Simbra.Dominio.Common;
using FC.Simbra.Dominio.Gerencial.Disciplinas;

namespace FC.Simbra.Dominio.Gerencial
{
    public class AlunoDisciplina : Entidade<int>
    {
        public virtual Aluno Aluno { get; set; }
        public virtual Disciplina Disciplina { get; set; }
        public virtual decimal Nota { get; set; }

        public AlunoDisciplina()
        { }

        public AlunoDisciplina(Aluno aluno, Disciplina disciplina)
        {
            Aluno = aluno;
            Disciplina = disciplina;
        }
    }
}