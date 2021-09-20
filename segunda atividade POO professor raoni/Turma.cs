using System;

namespace Modelos
{
    public class Turma
    {
        public String numeroDaTurma;
        public String numeroDaSala;
        public String disciplina;
        public char bloco;
        public Boolean disponivel;
        public Professor professor;
        public Turma()
        {
            Console.WriteLine("... Criando Turma");
        }
        public Turma (String numeroDaTurma, String numeroDaSala, String disciplina, char bloco, Boolean disponivel)
        {
            this.numeroDaTurma = numeroDaTurma;
            this.numeroDaSala = numeroDaSala;
            this.disciplina = disciplina;
            this.bloco = bloco;
            this.disponivel = disponivel;
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"A turma é {this.numeroDaTurma} {this.disciplina} na sala {this.numeroDaTurma} do bloco {this.bloco}, cujo professor é {this.professor.nome} e está disponível? {ConverterParaSimOuNao(this.disponivel)}");
        }
        private string ConverterParaSimOuNao(bool parametro)
        {
            return parametro ? "Sim" : "Não";
        }
    }
}