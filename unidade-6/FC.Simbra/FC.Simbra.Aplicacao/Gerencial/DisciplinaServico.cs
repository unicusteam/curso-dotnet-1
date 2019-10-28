using FC.Simbra.Aplicacao.Common;
using FC.Simbra.Dominio.Gerencial.Disciplinas;
using FC.Simbra.Infraestrutura.Gerencial.Repositorios;

namespace FC.Simbra.Aplicacao.Gerencial
{
    public class DisciplinaServico : ServicoAplicacao<Disciplina, int, IDisciplinaRepositorio>
    {
        public DisciplinaServico()
        {
            repositorio = new DisciplinaRepositorio();
            validador = new DisciplinaValidador();
        }
    }
}
