using FC.Simbra.Dominio.Gerencial;
using FluentNHibernate.Mapping;

namespace FC.Simbra.Infraestrutura.Gerencial.Mapeamentos
{
    public class AlunoDisciplinaMap : ClassMap<AlunoDisciplina>
    {
        public AlunoDisciplinaMap()
        {
            Table("TBALUNODISCIPLINA");
            Id(c => c.Id);

            References(c => c.Aluno).Column("AlunoId");
            References(c => c.Disciplina).Column("DisciplinaId");

            Map(c => c.Nota);
        }
    }
}
