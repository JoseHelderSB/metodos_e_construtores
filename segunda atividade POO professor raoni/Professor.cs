using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Professor : Pessoa
    {       
        public String cpf;
        public Turma turma;
        public Professor(string nome, string sexo, string cpf, string identidade, int idade, bool maiorDeIdade) : base(nome, sexo, cpf, identidade, idade, maiorDeIdade)
        {
        }
    }
}
