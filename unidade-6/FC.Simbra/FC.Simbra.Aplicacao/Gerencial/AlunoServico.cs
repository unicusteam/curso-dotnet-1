using FC.Simbra.Aplicacao.Common;
using FC.Simbra.Dominio.Gerencial;
using FC.Simbra.Infraestrutura.Gerencial.Repositorios;
using System.Collections.Generic;

namespace FC.Simbra.Aplicacao.Gerencial
{
    public class AlunoServico : ServicoAplicacao<Aluno, int, IAlunoRepositorio>
    {
        public AlunoServico()
        {
            repositorio = new AlunoRepositorio();
            validador = new AlunoValidador(repositorio);
        }

        public IList<Aluno> ObterTodosPorNome(string nome)
        {
            return repositorio.ObterTodosPorNome(nome);
        }
    }
}
