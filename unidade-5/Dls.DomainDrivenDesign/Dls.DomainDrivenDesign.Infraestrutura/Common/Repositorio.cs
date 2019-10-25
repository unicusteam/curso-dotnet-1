using Dls.DomainDrivenDesign.Dominio.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dls.DomainDrivenDesign.Infraestrutura.Common
{
    public abstract class Repositorio<TEntidade, TId> : IRepositorio<TEntidade, TId>
    {
        public virtual void Excluir(TId id)
        {
           ///NhibernateHelper.
        }

        public virtual TEntidade Obter(TId id)
        {
            throw new NotImplementedException();
        }

        public virtual IList<TEntidade> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public virtual void Salvar(TEntidade entidade)
        {
            throw new NotImplementedException();
        }
    }
}
