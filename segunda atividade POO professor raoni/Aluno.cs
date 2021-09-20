using System;

namespace Modelos
{
    public class Aluno : Pessoa
    {
        public int matricula;        
        public Curso curso;
        public Aluno(string nome, string sexo, string cpf, string identidade, int idade, bool maiorDeIdade, int matricula) : base(nome, sexo, cpf, identidade, idade, maiorDeIdade)
        {
            this.matricula = matricula;
        }
        public Aluno(string nome, string sexo, string cpf, string identidade, int idade, bool maiorDeIdade, int matricula, Curso curso) : this(nome, sexo, cpf, identidade, idade, maiorDeIdade, matricula)
        {
            this.curso = curso;
        }
    }
}
