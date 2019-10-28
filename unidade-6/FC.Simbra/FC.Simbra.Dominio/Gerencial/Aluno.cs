using FC.Simbra.Dominio.Common;
using FC.Simbra.Dominio.Gerencial.Cidades;
using FC.Simbra.Dominio.Gerencial.Disciplinas;
using System;
using System.Collections.Generic;

namespace FC.Simbra.Dominio.Gerencial
{
    public class Aluno : Pessoa<int>
    {
        public virtual string Matricula { get; set; }
        public virtual Cidade Naturalidade { get; set; }
        public virtual IList<AlunoDisciplina> Disciplinas { get; set; }

        public Aluno()
        {
            Disciplinas = new List<AlunoDisciplina>();
        }

        public Aluno(string nome, string matricula, DateTime dataNascimento)
            : this()
        {
            Nome = nome;
            Matricula = matricula;
            DataNascimento = dataNascimento;
        }

        public virtual void AdicionarDisciplina(Disciplina disciplina)
        {
            Disciplinas.Add(new AlunoDisciplina(this, disciplina));
        }
    }
}
