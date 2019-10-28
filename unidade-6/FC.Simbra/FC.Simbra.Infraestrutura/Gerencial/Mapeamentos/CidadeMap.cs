using FC.Simbra.Dominio.Gerencial.Cidades;
using FluentNHibernate.Mapping;

namespace FC.Simbra.Infraestrutura.Gerencial.Mapeamentos
{
    public class CidadeMap : ClassMap<Cidade>
    {
        public CidadeMap()
        {
            Table("TBCIDADE");
            Id(c => c.Id);
            Map(c => c.Nome).Not.Nullable().Length(100);
        }
    }
}
