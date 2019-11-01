using FC.Simbra.Dominio.Gerencial.Disciplinas;
using FC.Simbra.Infraestrutura.Common;
using NHibernate;

namespace FC.Simbra.Infraestrutura.Gerencial.Repositorios
{
    public class DisciplinaRepositorio : Repositorio<Disciplina, int>, IDisciplinaRepositorio
    {
        public DisciplinaRepositorio(ISession session) : base(session)
        {
        }
    }
}
