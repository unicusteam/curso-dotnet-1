using Dls.DomainDrivenDesign.Dominio.Common;
using System.Collections.Generic;

namespace Dls.DomainDrivenDesign.Aplicacao.Common
{
    public class ServicoAplicacao<TEntidade, TId, TRepositorio>
        where TRepositorio : IRepositorio<TEntidade, TId>
    {
        protected TRepositorio repositorio;

        public virtual void Salvar(TEntidade entidade)
        {
            repositorio.Salvar(entidade);
        }

        public virtual TEntidade Obter(TId id)
        {
            return repositorio.Obter(id);
        }

        public virtual IList<TEntidade> ObterTodos()
        {
            return repositorio.ObterTodos();
        }

        public virtual void Excluir(TId id)
        {
            repositorio.Excluir(id);
        }
    }
}
