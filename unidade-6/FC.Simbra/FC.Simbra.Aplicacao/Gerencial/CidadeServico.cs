using FC.Simbra.Aplicacao.Common;
using FC.Simbra.Dominio.Gerencial.Cidades;
using FC.Simbra.Infraestrutura.Gerencial.Repositorios;

namespace FC.Simbra.Aplicacao.Gerencial
{
    public class CidadeServico : ServicoAplicacao<Cidade, int, ICidadeRepositorio>
    {
        public CidadeServico()
        { }

        public CidadeServico(UnitOfWork unidade) : base(unidade)
        { }

        protected override void InicializarServico()
        {
            repositorio = new CidadeRepositorio(Unidade.Sessao);
            validador = new CidadeValidador();
        }
    }
}
