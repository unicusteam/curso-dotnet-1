using Dls.DomainDrivenDesign.Dominio.Gerencial.Alunos;
using Dls.DomainDrivenDesign.Infraestrutura.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dls.DomainDrivenDesign.Infraestrutura.Gerencial.Repositorios
{
    public class AlunoRepositorio : Repositorio<Aluno, int>, IAlunoRepositorio
    {
        public IList<Aluno> ObterTodosPorNome(string nome)
        {
           return NhibernateHelper.OpenSession().Query<Aluno>().Where(c => c.Nome.StartWith(nome)).ToList();
        }
    }
}
