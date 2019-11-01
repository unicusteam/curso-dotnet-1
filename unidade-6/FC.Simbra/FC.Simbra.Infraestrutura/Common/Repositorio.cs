using FC.Simbra.Dominio.Common;
using NHibernate;
using System.Collections.Generic;
using System.Linq;

namespace FC.Simbra.Infraestrutura.Common
{
    public abstract class Repositorio<TEntidade, TId> : IRepositorio<TEntidade, TId>
    {
        protected readonly ISession session;

        public Repositorio(ISession session)
        {
            this.session = session;
        }
         public void Excluir(TId id)
        {
            session.Delete(session.Get<TEntidade>(id));
        }

        public virtual TEntidade Obter(TId id)
        {
            return session.Get<TEntidade>(id);
        }

        public virtual IList<TEntidade> ObterTodos()
        {
            return session.Query<TEntidade>().ToList();
        }

        public virtual void Salvar(TEntidade entidade)
        {
            session.Merge(entidade);
        }
    }
}
