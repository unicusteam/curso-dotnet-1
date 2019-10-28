using FC.Simbra.Dominio.Gerencial;
using FC.Simbra.Infraestrutura.Common;
using FC.Simbra.Infraestrutura.Helpers;
using NHibernate;
using NHibernate.Linq;
using System.Collections.Generic;
using System.Linq;

namespace FC.Simbra.Infraestrutura.Gerencial.Repositorios
{
    public class AlunoRepositorio : Repositorio<Aluno, int>, IAlunoRepositorio
    {
        public IList<Aluno> ObterTodosPorNome(string nome)
        {
            return NHibernateHelper.OpenSession().Query<Aluno>().Where(c => c.Nome.StartsWith(nome)).ToList();
        }

        public bool ExisteMatricula(Aluno aluno)
        {
            return NHibernateHelper.OpenSession().Query<Aluno>().Where(c => !c.Id.Equals(aluno.Id)).Any(C => C.Matricula.Equals(aluno.Matricula));
        }

        public override IList<Aluno> ObterTodos()
        {
            return NHibernateHelper.OpenSession()
                .Query<Aluno>()
                .Fetch(c => c.Naturalidade)
                .FetchMany(c => c.Disciplinas)
                    .ThenFetch(c => c.Disciplina)
                .ToList();
        }
    }
}
