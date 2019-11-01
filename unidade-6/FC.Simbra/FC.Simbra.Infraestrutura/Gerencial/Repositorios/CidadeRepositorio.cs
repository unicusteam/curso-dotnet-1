using FC.Simbra.Dominio.Gerencial.Cidades;
using FC.Simbra.Infraestrutura.Common;
using NHibernate;

namespace FC.Simbra.Infraestrutura.Gerencial.Repositorios
{
    public class CidadeRepositorio : Repositorio<Cidade, int>, ICidadeRepositorio
    {
        public CidadeRepositorio(ISession session) : base(session)
        {
        }
    }
}
