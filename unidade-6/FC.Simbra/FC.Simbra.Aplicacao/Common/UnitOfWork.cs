using FC.Simbra.Infraestrutura.Helpers;
using NHibernate;


namespace FC.Simbra.Aplicacao.Common
{
    public class UnitOfWork
    {
        private ITransaction transacao;

        public ISession Sessao { get; }


        public UnitOfWork()
        {
            Sessao = NHibernateHelper.OpenSession();
        }

        public void AbrirTransacao()
        {
            transacao = Sessao.BeginTransaction();
        }

        public void Commit()
        {
            transacao.Commit();
        }

        public void Rollback()
        {
            transacao.Rollback();
        }
    }
}
