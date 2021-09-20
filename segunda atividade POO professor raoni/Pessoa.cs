using System;

namespace Modelos
{
    public class Pessoa
    {
        public String nome;
        public String sexo; 
        public String cpf;
        public String identidade;
        public int idade;
        private bool maiorDeIdade;
        public Pessoa(string nome, string sexo, string cpf, string identidade, int idade, bool maiorDeIdade)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.cpf = cpf;
            this.identidade = identidade;
            this.idade = idade;
            this.maiorDeIdade = maiorDeIdade;
        }
        public void DizerOi()
        {
            Console.WriteLine($"Olá, eu sou {this.nome}.");
        }

        public void FazerAniversário() //Questão 05, apenas o incremento de uma idade.
        {
            idade++;
            
        }

        public void Saudacao() //Questão 06
        {
            if (idade >= 18)
            {
                maiorDeIdade = true; //Questão 08
            }
            else maiorDeIdade = false; //tive que fazer o else
        
            Console.WriteLine($"Olá, eu sou {this.nome} e tenho {this.idade} anos e {Maioridade(this.maiorDeIdade)} maior de idade"); //Questão 09
        }

        private string Maioridade (bool parametro) //método pra ficar mais intuitivo o console
        {
            return parametro ? "sou" : "não sou";
        }
    }

}
