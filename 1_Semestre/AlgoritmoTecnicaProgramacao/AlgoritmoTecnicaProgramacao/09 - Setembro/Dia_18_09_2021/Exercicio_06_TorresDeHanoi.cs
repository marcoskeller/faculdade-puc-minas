using System;

namespace AlgoritmoTecnicaProgramacao.Dia_18_09_2021
{ 
    public class  Exercicio_06_TorresDeHanoi
    {
        /*
         * 6) O jogo das Torres de Hanoi é constituído de 3 pinos e n discos. 
              O objetivo do jogo é transferir os n discos do pino de origem para o pino de destino 
              utilizando o terceiro pino como apoio. Para n discos o jogo possui como solução ótima 
              a solução com o menor número de movimentos possível, que é igual a 2n - 1 movimentos. 
              Construa um algoritmo em C# que:

                a) leia o número de discos utilizados em determinada partida do jogo e o número de movimentos 
                   que foram utilizados para mover os discos;

                b) exiba uma das duas mensagens a seguir para o usuário: 
                   (1) ``Parabéns! Solução ótima! Jogo solucionado no menor número de movimentos possível!'' ou 
                   (2) ``Parabéns! Jogo solucionado com x movimentos a mais que a solução ótima!''.
         */

        public static void TorresDeHanoi()
        {
            Console.Clear();
            Console.WriteLine("\n\n-------->Torre de Hanoi<-------------------");
            int quantidadeDiscos, numeroMovimentos, resultado, quantidadeMovimentes;



            Console.Write("\n\nDigite a quantidade de Discos utilizados na Partida: ");
            quantidadeDiscos = int.Parse(Console.ReadLine());

            Console.Write("\n\nDigite a quantidade de movimentos usados na Partida: ");
            numeroMovimentos = int.Parse(Console.ReadLine());

            resultado = (2 * quantidadeDiscos) - 1 ;

            if(resultado == numeroMovimentos)
            {
                Console.WriteLine("\n\nJogo solucionado com " + resultado + " movimentos.");
                Console.WriteLine("\nParabéns! Solução ótima! Jogo solucionado no menor número de movimentos possível!");
            }
            else
            {
                quantidadeMovimentes = numeroMovimentos - resultado;
                Console.WriteLine("\n\nParabéns! Jogo solucionado com " + quantidadeMovimentes + " movimentos a mais que a solução ótima!");
            }
        }         
    }
}
