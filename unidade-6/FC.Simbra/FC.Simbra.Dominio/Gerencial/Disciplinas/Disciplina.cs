using FC.Simbra.Dominio.Common;

namespace FC.Simbra.Dominio.Gerencial.Disciplinas
{
    public class Disciplina : Entidade<int>
    {
        public virtual string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
