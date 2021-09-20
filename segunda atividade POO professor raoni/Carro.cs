using System;

namespace Modelos
{
    public class Carro
    {
        public String marca;
        public String modelo;
        public String cor;
        public int ano;
        public double velocidadeMaxima;
        private double velocidade;
        public Carro(string marca, string modelo, string cor, int ano, double velocidadeMaxima)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.ano = ano;
            this.velocidadeMaxima = velocidadeMaxima;
        }
        
        /*Após entender os métodos citados abaixo sobre acelerar, chegamos no método 'Correr', esse método o professor criou simplesmente
         pra percorrer um laço de repetição onde a 'aceleração' será incrementada 20 vezes*/
        public void Correr(double aceleracao) //o parâmetro passado é o de 'aceleracao'
        {

            for (int i = 0; i < 20; i++)
            {
                /*A chamada da função 'Acelerar' na versão com parâmetro (que é a prórpria aceleração que terá seu argumento recebido
                na classe Program) que será chamado 20 vezes devido ao laço for*/
                Acelerar(aceleracao);
                /*Será impresso na tela 20 vezes a frase onde possui os atributos 'marca', 'modelo' e então o resultado da
                 velocidade [que vem do ObterVelocidade()] que for sendo retornada durante a incrementação do retorno*/                     
                Console.WriteLine($"A velocidade do {this.marca} {this.modelo} é {this.ObterVelocidade()} ...");

            }
        }

        /*Aqui o professor simplesmente fez uma sobrecarga (overload) do método Correr, agora na versão sem parâmetros,
         e definiu como padrão uma 'aceleracao' que poderia ser qualquer outro número, mas o professor no exemplo
        decidiu definir como '5'*/
        public void Correr()
        {
            Correr(5);
        }


        /*Esse método o professor tirou o '5' e colocou 'aceleracao' pra poder modificar a velocidade que o carro acelera.
        O porsche é mais rápido, então nao dava pra usar o mesmo método, fica a critério do argumento que será passado, que sera
        o 'aceleracao'*/
        private void Acelerar(double aceleracao)
        {
            velocidade += aceleracao; //por padrão 'velocidade' começa com zero quando não é declarada, ela receberá a 'aceleracao' inicial e depois será incrementada.
            if (velocidade >= velocidadeMaxima) //caso a 'velocidade' seja maior ou igual a 'velocidadeMaxima'...
            {
                velocidade = velocidadeMaxima;// ela recebe o valor da velocidade máxima e não ultrapassará disso.
            }
        }
        /*Aqui o professor fez uma sobrecarga do método Acelerar, agora não passando parâmetros. Dentro desse método
         ele chama o método 'Acelerar', a versão que recebe parâmetro, e define um valor padrão de argumento como '5'
        isso pra poder chamar na classe Program com a instância do Fusca e fazer ele acelerar de 5 e 5*/
        private void Acelerar()
        {
            Acelerar(5);
        }

        /*Nesse método, temos como única função retornar a velocidade. Entendi apenas como uma abstração, separar mais ainda as coisas
         e fazer com que cada método execute sua função, ele simplesmente retorna a variável 'velocidade' pra obtermos a mesma*/
        public double ObterVelocidade()
        {
            return velocidade;
        }

        ///---------------------------------------------ATIVIDADE 
        public void Frear(double velocidadeDeFrenagem)//Questão 02
        {
            velocidade = velocidade - velocidadeDeFrenagem ;
            if (velocidade <= 0)
                velocidade = 0;// isso pq caso o método seja chamado várias vezes, a decrementação não fique abaixo de zero.

            Console.WriteLine($"A velocidade do {this.marca} {this.modelo} agora é {this.velocidade} ...");

        }
        public void Frear()//Questão 03
        {
            Frear(5);
        }


    }

}