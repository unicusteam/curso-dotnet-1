using FC.Simbra.Dominio.Gerencial;
using FC.Simbra.Infraestrutura.Common;
using NHibernate;
using NHibernate.Linq;
using System.Collections.Generic;
using System.Linq;

namespace FC.Simbra.Infraestrutura.Gerencial.Repositorios
{
    public class AlunoRepositorio : Repositorio<Aluno, int>, IAlunoRepositorio
    {
        public AlunoRepositorio(ISession session) : base(session)
        {
        }

        public IList<Aluno> ObterTodosPorNome(string nome)
        {
            return session.Query<Aluno>().Where(c => c.Nome.StartsWith(nome)).ToList();
        }

        public bool ExisteMatricula(Aluno aluno)
        {
            return session.Query<Aluno>().Where(c => !c.Id.Equals(aluno.Id)).Any(C => C.Matricula.Equals(aluno.Matricula));
        }

        public override IList<Aluno> ObterTodos()
        {
            return session
                .Query<Aluno>()
                .Fetch(c => c.Naturalidade)
                .FetchMany(c => c.Disciplinas)
                    .ThenFetch(c => c.Disciplina)
                .ToList();
        }
    }
}
