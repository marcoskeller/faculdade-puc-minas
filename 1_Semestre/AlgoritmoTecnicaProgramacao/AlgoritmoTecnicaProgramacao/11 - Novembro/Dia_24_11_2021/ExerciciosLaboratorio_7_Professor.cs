using System;
using System.Collections.Generic;


namespace AlgoritmoTecnicaProgramacao.Dia_24_11_2021
{
    public class ExerciciosLaboratorio_7_Professor
    {
        public static void ExerciciosAvaliativosLaboratorio_7()
        {
            /*int[] V;
           int n, x, i, cont = 0;


           Console.Write("Tamanho do vetor: ");
           n = int.Parse(Console.ReadLine());

           V = new int[n];

           Console.WriteLine("Número que serão armazenados no vetor: ");


           for (i = 0; i < n; i++)
           {
               Console.Write($"{i+1}o. número: ");
               V[i] = int.Parse(Console.ReadLine());
           }


           Console.Write("Número a ser procurado: ");
           x = int.Parse(Console.ReadLine());


           cont = contagemOcorrencias(x, V);


           if (cont == 0) // x não encontrado
               Console.WriteLine($"{x} não está presente no vetor.");
           else
               Console.WriteLine($"{x} está presente no vetor {cont} vezes");


           Console.WriteLine($"O maior número do vetor é {maiorElemento(V)}.");*/


            int i, n, p;
            int[] VP;


            Console.Write("Tamanho do vetor: ");
            n = int.Parse(Console.ReadLine());


            VP = new int[n];


            p = 2;


            // percorrer o vetor de números primos
            for (i = 0; i < n; i++)
            {
                VP[i] = p;



                p++;



                while (primo(p) == false)
                {
                    p++;
                }
                   
            }

            exibeVetor(VP, "Vetor de números primos");

            Console.ReadKey();
        }

        static int divisores(int n)
        {
            int i, cont = 0;



            for (i = 1; i <= n; i++)
                if (n % i == 0)
                    cont++;



            return (cont);
        }

        static bool primo(int n)
        {
            if (divisores(n) > 2)
                return (false);
            else
                return (true);
        }

        static int contagemOcorrencias(int x, int[] V)
        {
            int i, cont = 0;



            for (i = 0; i < V.Length; i++)
                if (V[i] == x)
                    cont++;



            return (cont);
        }

        static int maiorElemento(int[] V)
        {
            int maior = V[0];
            int i;



            for (i = 1; i < V.Length; i++)
                if (V[i] > maior)
                    maior = V[i];



            return (maior);
        }

        static void exibeVetor(int[] V, string msg)
        {
            int i;



            Console.WriteLine(msg);



            for (i = 0; i < V.Length; i++)
            {
                Console.Write($"{V[i]}, ");
            }
        }
    }

}
