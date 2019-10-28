using FC.Simbra.Dominio.Common;
using System.Collections.Generic;

namespace FC.Simbra.Dominio.Gerencial
{
    public interface IAlunoRepositorio : IRepositorio<Aluno, int>
    {
        IList<Aluno> ObterTodosPorNome(string nome);

        public bool ExisteMatricula(Aluno aluno);
    }
}
