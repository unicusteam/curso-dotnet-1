using FC.Simbra.Dominio.Gerencial.Disciplinas;
using FluentNHibernate.Mapping;

namespace FC.Simbra.Infraestrutura.Gerencial.Mapeamentos
{
    public class DisciplinaMap : ClassMap<Disciplina>
    {
        public DisciplinaMap()
        {
            Table("TBDISCIPLINA");
            Id(c => c.Id);
            Map(c => c.Nome).Not.Nullable().Length(100);
        }
    }
}
