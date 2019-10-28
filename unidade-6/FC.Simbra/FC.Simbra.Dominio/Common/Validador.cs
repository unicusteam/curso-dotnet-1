using System.Collections.Generic;

namespace FC.Simbra.Dominio.Common
{
    public abstract class Validador<TEntidade, TId> : IValidador<TEntidade>
    {
        public IList<string> Validacoes { get; }

        public Validador()
        {
            Validacoes = new List<string>();
        }

        public virtual bool Validar(TEntidade entidade)
        {
            return true;
        }
    }

    public abstract class Validador<TEntidade, TId, TRepositorio> : Validador<TEntidade, TId>
        where TRepositorio : IRepositorio<TEntidade, TId>
    {
        protected readonly TRepositorio repositorio;

        public Validador(TRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }
    }
}
