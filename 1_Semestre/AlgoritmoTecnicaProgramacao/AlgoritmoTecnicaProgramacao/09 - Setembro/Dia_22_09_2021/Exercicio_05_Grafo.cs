using System;

namespace AlgoritmoTecnicaProgramacao.Dia_22_09_2021
{
    public class  Exercicio_05_Grafo
    {
        /*
         * 5) Um grafo é uma estrutura de dados que é constituída de elementos chamados de vértices e arestas. 
              Considerando-se que um grafo tenha n vértices e m arestas, o número de arestas de um grafo pode 
              variar de 0 (valor mínimo) a n(n-1)/2 (valor máximo). 
              Faça um algoritmo em C# que:
                a) leia a quantidade de vértices e arestas de um grafo;
                b) verifique se o número de arestas informado é válido (se está na faixa informada);
                c) verifique se o grafo é completo (se tem o maior número de arestas possível).
         */

        public static void Grafo()
        {
            Console.Clear();
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>Grafo<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            int quantidadeVertices, quantidadeArestas, quantidadeMaximaArestas;


            Console.Write("\n\nDigite a quantidade de vértices: ");
            quantidadeVertices = int.Parse(Console.ReadLine());

            Console.Write("\n\nDigite a quantidade de arestas: ");
            quantidadeArestas = int.Parse(Console.ReadLine());

            quantidadeMaximaArestas = (quantidadeVertices * (quantidadeVertices - 1)) / 2;

            if(quantidadeArestas >= 0  && quantidadeArestas <= quantidadeMaximaArestas)
            {
                Console.WriteLine("\n\nO número de aresta informado e válido!");
                
                if(quantidadeArestas == quantidadeMaximaArestas)
                {
                    Console.WriteLine("\n\nO Grafo é Completo!\nO valor de aresta informado (" + quantidadeArestas + ") é o número máximo (" 
                        + quantidadeMaximaArestas + ") de aresta que o Grafo pode ter!");
                }
                else
                {
                    Console.WriteLine("\n\nO Grafo não é Completo!\nO valor de aresta informado  (" + quantidadeArestas + ") não é o número máximo ("
                        + quantidadeMaximaArestas + ") de aresta que o Grafo pode ter!");
                }
            }
            else
            {
                Console.WriteLine("\n\nNúmero de aresta informado é inválido!");
            }
        }
    }
}
