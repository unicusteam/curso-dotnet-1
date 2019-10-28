using FC.Simbra.Infraestrutura.Helpers;


namespace FC.Simbra.Aplicacao.Common
{
    public static class ConfigurarAplicacao
    {
       public static void ConfigurarNHibernate()
        {
            NHibernateHelper.Configurar();
        }
    }
}
