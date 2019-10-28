using System.Collections.Generic;
using System.Linq;
using FC.Simbra.Dominio.Common;
using FC.Simbra.Infraestrutura.Helpers;

namespace FC.Simbra.Infraestrutura.Common
{
    public abstract class Repositorio<TEntidade, TIdentificador> : IRepositorio<TEntidade, TIdentificador>
    {
         public void Excluir(TIdentificador id)
        {
            NHibernateHelper.OpenSession(true).Delete(NHibernateHelper.OpenSession().Get<TEntidade>(id));
            NHibernateHelper.Commit();
        }

        public virtual TEntidade Obter(TIdentificador id)
        {
            return NHibernateHelper.OpenSession().Get<TEntidade>(id);
        }

        public virtual IList<TEntidade> ObterTodos()
        {
            return NHibernateHelper.OpenSession().Query<TEntidade>().ToList();
        }

        public virtual void Salvar(TEntidade entidade)
        {
            NHibernateHelper.OpenSession(true).Merge(entidade);
            NHibernateHelper.Commit();
        }
    }
}
