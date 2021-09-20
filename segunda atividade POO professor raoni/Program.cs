using System;
using Modelos; 

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Turma turma = new Turma("ADS001A", "A001", "CODING", 'A', true);
            Aluno a = new Aluno("Rodrigo", "M", "777", "888", 17, true, 1212);
            a.DizerOi();
            a.Saudacao();

            Pessoa p = new Pessoa("Helder", "M", "999", "58844", 25, true);
            p.Saudacao();//saudação com idade Real
            for (int i=0; i<20; i++) //Questão 07 fazendo aniversário 20 vezes
            {   
                if(i==15)//Questão 10
                {
                    p.Saudacao();
                    Console.WriteLine("15º aniversário");
                }
                else if (i==20)
                {
                    p.Saudacao();
                    Console.WriteLine("20º aniversário");
                }
                p.FazerAniversário();
                Console.WriteLine($"Olá, tenho {p.idade} anos.");
            }
            p.Saudacao();

            /*
             Professor prof = new Professor("Raoni", "M", "1234", "5678");
             prof.DizerOi();

             prof.turma = turma;    
             turma.professor = prof;

             turma.ExibirInformacoes();

             Carro fusca = new Carro("Volkswagen", "Fusca", "Azul",  1995, 120);
             fusca.Correr();
             fusca.Frear();//Questão 04 - frenagem padrão

             Carro porsche = new Carro("Porsche", "911 Carrera S", "Cinza", 2017, 320);
             porsche.Correr(20);
             porsche.Frear(100);//Questão 04 - frenagem com argumento
            */
        }
    }
}