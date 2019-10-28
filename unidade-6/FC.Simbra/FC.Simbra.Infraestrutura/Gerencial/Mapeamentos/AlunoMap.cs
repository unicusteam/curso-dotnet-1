using FC.Simbra.Dominio.Gerencial;
using FluentNHibernate.Mapping;

namespace FC.Simbra.Infraestrutura.Gerencial.Mapeamentos
{
    public class AlunoMap : ClassMap<Aluno>
    {
        public AlunoMap()
        {
            Table("TBALUNO");

            Id(c => c.Id);

            Map(c => c.Nome);
            Map(c => c.Matricula);
            Map(c => c.DataNascimento);

            References(c => c.Naturalidade).Column("NaturalidadeId");

            HasMany(c => c.Disciplinas)
                .Cascade.AllDeleteOrphan();
        }
    }
}
