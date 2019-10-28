using FC.Simbra.Aplicacao.Common;
using FC.Simbra.Dominio.Gerencial.Cidades;
using FC.Simbra.Infraestrutura.Gerencial.Repositorios;

namespace FC.Simbra.Aplicacao.Gerencial
{
    public class CidadeServico : ServicoAplicacao<Cidade, int, ICidadeRepositorio>
    {
        public CidadeServico()
        {
            repositorio = new CidadeRepositorio();
            validador = new CidadeValidador();
        }
    }
}
