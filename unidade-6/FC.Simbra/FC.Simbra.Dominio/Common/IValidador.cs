using System.Collections.Generic;

namespace FC.Simbra.Dominio.Common
{
    public interface IValidador<TEntidade>
    {
        IList<string> Validacoes { get; }
        bool Validar(TEntidade entidade);
    }
}
