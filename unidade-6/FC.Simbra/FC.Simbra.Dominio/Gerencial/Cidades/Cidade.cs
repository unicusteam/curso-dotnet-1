using FC.Simbra.Dominio.Common;

namespace FC.Simbra.Dominio.Gerencial.Cidades
{
    public class Cidade : Entidade<int>
    {
        public virtual string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
