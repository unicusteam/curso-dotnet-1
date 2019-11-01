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

        public UnitOfWork Unidade { get; }

        protected TRepositorio repositorio;
        protected IValidador<TEntidade> validador;

        public ServicoAplicacao() : this(new UnitOfWork())
        {
        }

        public ServicoAplicacao(UnitOfWork unidade)
        {
            Unidade = unidade;
            InicializarServico();
        }

        protected virtual void InicializarServico()
        {

        }

        public virtual bool Salvar(TEntidade entidade)
        {
            try
            {
                Unidade.AbrirTransacao();

                if (!validador.Validar(entidade))
                {
                    return false;
                }

                repositorio.Salvar(entidade);

                Unidade.Commit();

                return true;
            }
            catch (System.Exception ex)
            {

                Unidade.Rollback();
                throw ex;
            }
            
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
