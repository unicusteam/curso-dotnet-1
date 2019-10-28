using System.Collections.Generic;

namespace FC.Simbra.Dominio.Common
{
    public interface IRepositorio<TEntidade, TIdentificador>
    {
        TEntidade Obter(TIdentificador id);

        IList<TEntidade> ObterTodos();

        public void Salvar(TEntidade entidade);

        void Excluir(TIdentificador id);  
    }
}
