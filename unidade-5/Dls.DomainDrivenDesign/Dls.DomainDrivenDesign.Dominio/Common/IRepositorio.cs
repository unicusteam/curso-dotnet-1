using System.Collections.Generic;

namespace Dls.DomainDrivenDesign.Dominio.Common
{
    public interface IRepositorio<TEntidade, TId>
    {
        void Salvar(TEntidade entidade);
        void Excluir(TId id);
        TEntidade Obter(TId id);
        IList<TEntidade> ObterTodos();
    }
}
