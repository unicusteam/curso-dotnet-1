using FC.Simbra.Dominio.Common;
using System.Collections.Generic;
using System.Linq;

namespace FC.Simbra.Aplicacao.Common
{
    public class ServicoAplicacao<TEntidade, TIdentificador, TRepositorio>
        where TRepositorio : IRepositorio<TEntidade, TIdentificador>
    {
        public bool ResultadoValido { get { return !Validacoes.Any();  } }
        public IList<string> Validacoes { get { return validador.Validacoes; } }

        protected TRepositorio repositorio;
        protected IValidador<TEntidade> validador;

        public virtual bool Salvar(TEntidade entidade)
        {
            if (!validador.Validar(entidade))
            {
                return false;
            }

            repositorio.Salvar(entidade);
            return true;
        }

        public virtual TEntidade Obter(TIdentificador id)
        {
            return repositorio.Obter(id);
        }

        public virtual IList<TEntidade> ObterTodos()
        {
            return repositorio.ObterTodos();
        }

        public virtual void Excluir(TIdentificador id)
        {
            repositorio.Excluir(id);
        }
    }
}
