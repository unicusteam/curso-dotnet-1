using FC.Simbra.Aplicacao.Common;
using FC.Simbra.Dominio.Gerencial;
using FC.Simbra.Infraestrutura.Gerencial.Repositorios;
using System.Collections.Generic;

namespace FC.Simbra.Aplicacao.Gerencial
{
    public class AlunoServico : ServicoAplicacao<Aluno, int, IAlunoRepositorio>
    {

        public AlunoServico()
        { }

        public AlunoServico(UnitOfWork unidade) : base(unidade)
        {
        }

        protected override void InicializarServico()
        {
            repositorio = new AlunoRepositorio(Unidade.Sessao);
            validador = new AlunoValidador(repositorio);
        }

        public IList<Aluno> ObterTodosPorNome(string nome)
        {
            return repositorio.ObterTodosPorNome(nome);
        }
    }
}
