using Dls.DomainDrivenDesign.Aplicacao.Common;
using Dls.DomainDrivenDesign.Dominio.Gerencial.Alunos;
using Dls.DomainDrivenDesign.Infraestrutura.Gerencial.Repositorios;
using System.Collections.Generic;

namespace Dls.DomainDrivenDesign.Aplicacao
{
    public class AlunoServico : ServicoAplicacao<Aluno, int, IAlunoRepositorio>
    {
        public AlunoServico()
        {
            repositorio = new AlunoRepositorio();
        }

        public IList<Aluno> ObterTodosPorNome(string nome)
        {
            return repositorio.ObterTodosPorNome(nome);
        }
    }
}
