
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System.Reflection;

namespace FC.Simbra.Infraestrutura.Helpers
{
    public static class NHibernateHelper
    {
        private static ISessionFactory sessionFactory;

        public static void Configurar()
        {
            string connectionString = @"Data Source=.\DEV;Initial Catalog=Simbra;Integrated Security=True";

            MsSqlConfiguration configuracao = MsSqlConfiguration.MsSql2012.ConnectionString(connectionString);

            FluentConfiguration fluentConfiguracao = Fluently
                .Configure()
                .Database(configuracao)
                .Mappings(c =>
                {
                    c.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly());
                }).ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(true, true));

            sessionFactory = fluentConfiguracao.BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return sessionFactory.OpenSession();
        }

    }
}
