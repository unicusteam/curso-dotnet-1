using FC.Simbra.Dominio.Common;
using System;

namespace FC.Simbra.Dominio.Gerencial
{
    public class AlunoValidador : Validador<Aluno, int, IAlunoRepositorio>
    {
        public AlunoValidador(IAlunoRepositorio repositorio) 
            : base(repositorio)
        { }

        public override bool Validar(Aluno aluno)
        {
            Validacoes.Clear();

            if (string.IsNullOrEmpty(aluno.Nome))
            {
                Validacoes.Add("Nome é obrigatório.");
            }

            if (string.IsNullOrEmpty(aluno.Matricula))
            {
                Validacoes.Add("Matrícula é obrigatório.");
            }

            if (aluno.DataNascimento == DateTime.MinValue)
            {
                Validacoes.Add("Data de nascimento é obrigatório.");
            }

            if (aluno.DataNascimento >= DateTime.Now)
            {
                Validacoes.Add("Data de nascimento não pode ser maior que a data atual.");
            }

            if (repositorio.ExisteMatricula(aluno))
            {
                Validacoes.Add("Matrícula já existe."); 
            }

            if (aluno.Naturalidade == null)
            {
                Validacoes.Add("Cidade é obrigatório.");
            }

            return Validacoes.Count == 0;
        }
    }
}
