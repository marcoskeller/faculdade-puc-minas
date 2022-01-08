using System;

namespace AlgoritmoTecnicaProgramacao.Dia_18_09_2021
{
    public class  Exercicio_02_PartidaFutebol
    {
        /*
         *  2) Brasil e Alemanha jogaram uma partida de futebol amistosa recentemente. 
               Faça um algoritmo em C# para ler o número de gols das duas equipes na partida 
               e escrever um dos possíveis resultados: vitória do Brasil, 
               vitória da Alemanha ou empate.
         */

        public static void PartidaFutbeol()
        {
            Console.Clear();
            Console.WriteLine("\n\n-------->Situação de Uma Partida de Futebol<-------------------");
            int quantidadeGolsTimeA = 0, quantidadeGolsTimeB = 0;
            string timeA, timeB;

            Console.Write("\n\nDigite o Nome do Primeiro Time: ");
            timeA = Console.ReadLine();

            Console.Write("\n\nDigite a quantidade de gols do Primeiro time: ");
            quantidadeGolsTimeA = int.Parse(Console.ReadLine());

            Console.Write("\n\nDigite o Nome do Segundo Time: ");
            timeB = Console.ReadLine();

            Console.Write("\n\nDigite a quantidade de gols do Segundo time: ");
            quantidadeGolsTimeA = int.Parse(Console.ReadLine());

            if(quantidadeGolsTimeA > quantidadeGolsTimeB )
            {
                Console.WriteLine("O time " + timeA + "foi Campeão!");
            }
            else if(quantidadeGolsTimeA == quantidadeGolsTimeB)
            {
                Console.WriteLine("Houvem empate entre o time " + timeA + "e " + timeB);
            }
            else
            {
                Console.WriteLine("O time " + timeB + "foi Campeão!");
            }
               
        }
    }
}