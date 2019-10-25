using Dls.DomainDrivenDesign.Dominio.Common;
using System.Collections.Generic;

namespace Dls.DomainDrivenDesign.Dominio.Gerencial.Alunos
{
    public interface IAlunoRepositorio : IRepositorio<Aluno, int>
    {
        IList<Aluno> ObterTodosPorNome(string nome);
    }
}
