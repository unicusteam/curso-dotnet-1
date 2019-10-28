using System;

namespace FC.Simbra.Dominio.Common
{
    public abstract class Pessoa<TIndentificador> : Entidade<TIndentificador>
    {
        public virtual string Nome { get; set; }
        public virtual DateTime DataNascimento { get; set; }
    }
}
