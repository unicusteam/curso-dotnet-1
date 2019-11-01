using FC.Simbra.Aplicacao.Common;
using FC.Simbra.Dominio.Gerencial.Disciplinas;
using FC.Simbra.Infraestrutura.Gerencial.Repositorios;

namespace FC.Simbra.Aplicacao.Gerencial
{
    public class DisciplinaServico : ServicoAplicacao<Disciplina, int, IDisciplinaRepositorio>
    {
        public DisciplinaServico()
        { }

        public DisciplinaServico(UnitOfWork unidade) : base(unidade)
        { }

        protected override void InicializarServico()
        {
            repositorio = new DisciplinaRepositorio(Unidade.Sessao);
            validador = new DisciplinaValidador();
        }
    }
}
