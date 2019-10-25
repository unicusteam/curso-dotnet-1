public static class NhibernateHelper
{
    private static ISessionFactory sessionFactory;
    private static ITransaction transaction;
​
    public static void Configurar()
    {
        string connectionString = "Data Source=SERVIDOR;Initial Catalog=BancoDeDados;User ID=Usuario;Password=Senha";
​
        MsSqlConfiguration configuracao = MsSqlConfiguration.MsSql2012
            .ConnectionString(connectionString);
​
        FluentConfiguration fluentConfig = Fluently.Configure()
            .Database(configuracao)
            .Mappings(mappingConfiguration =>
            {
                mappingConfiguration.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly());
            }).ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(true, true));
​
        sessionFactory = fluentConfig.BuildSessionFactory();
    }
​
    public static ISession OpenSession(bool openTransaction = false)
    {
        var session = sessionFactory.OpenSession();
​
        if (openTransaction)
        {
            transaction = session.BeginTransaction();
        }
​
        return session;
    }
​
    public static void Commit()
    {
        transaction.Commit();
    }
}