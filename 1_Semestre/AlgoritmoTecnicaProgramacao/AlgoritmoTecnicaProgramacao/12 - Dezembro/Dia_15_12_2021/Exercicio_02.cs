using System;


namespace AlgoritmoTecnicaProgramacao.Dia_15_12_2021
{
    public class Exercicio_02
    {
        public static void Exercicio_2_ProvaFinal()
        {
            /*
             *Faça um programa em C# que:
                a) leia um número inteiro positivo n e crie um vetor de inteiros de n posições;
                b) leia um número inteiro positivo x e armazene no vetor criado os n primeiros números primos maiores que x;
                c) exiba o conteúdo do vetor. 
             */

            Console.Clear();
            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Exercicio 2<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

            int tamanhoVetor, numeroInformado;
            int[] vetorNumerosInformados, vetorNumerosImpares;


            Console.Write("\n\nInforme o tamanho do vetor desejado: ");
            tamanhoVetor = int.Parse(Console.ReadLine());

            vetorNumerosInformados = CriaVetor(tamanhoVetor, "\nVetor Numeros Informados!");

            Console.Write("\n\nInforme o numero que sera o parametro: ");
            numeroInformado = int.Parse(Console.ReadLine());

            NumerosImparesMaioresParametro(vetorNumerosInformados, numeroInformado);
        }

        static int[] CriaVetor(int tamanhoVetor, string msg)
        {
            int[] vetorCriado = new int[tamanhoVetor];
            int numeroInformado;

            Console.WriteLine(msg);
            Console.WriteLine("\n\nInforme os números para compor o Vetor!\n");

            for (int i = 0; i < tamanhoVetor; i++)
            {
                Console.Write((i + 1) + "º Elemento : ");
                numeroInformado = int.Parse(Console.ReadLine());
                vetorCriado[i] = numeroInformado;
            }
            return (vetorCriado);
        }

        static int[] NumerosImparesMaioresParametro(int[] vetorInformado, int parametroInformado)
        {
            int[] vetorNumerosImpares = new int[vetorInformado.Length];
            int contador = 0;

            for (int i = 0; i < vetorInformado.Length; i++)
            {
                if (vetorInformado[i] % 2 == 1)
                {
                    if (vetorInformado[i] > parametroInformado)
                    {
                        vetorNumerosImpares[contador] = vetorInformado[i];
                        contador++;
                    }
                }
            }

            ExibeVetorAtual(vetorNumerosImpares, contador, "\n\nVetor Criado com os Numeros Impares!\n\n");

            return (vetorNumerosImpares);
        }

        static void ExibeVetorAtual(int[] vetorInformado, int parametro, string msg)
        {
            int i;

            Console.WriteLine(msg);

            for (i = 0; i < parametro; i++)
            {
                if (i == (vetorInformado.Length - 1))
                {
                    Console.Write($"{vetorInformado[i]}\n");
                }
                else
                {
                    Console.Write($"{vetorInformado[i]}, ");
                }
            }

            Console.WriteLine("\n\n");
        }
    }
}
