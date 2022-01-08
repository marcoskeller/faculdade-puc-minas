using System;


namespace AlgoritmoTecnicaProgramacao.Dia_17_11_2021
{
    public class ExerciciosLaboratorio_6
    {
        public static void AcessarExerciciosLaboratorio_6()
        {
            /*
            * 3) Faça um programa em C# que:
                    a) leia um número inteiro positivo n;
                    b) armazene em um vetor os n primeiros números primos;
                    c) escreva o conteúdo do vetor.
            */

            Console.WriteLine("Atividade Laboratório 6");

            Console.Clear();
            Console.WriteLine("\n\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Operações com Vetores<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            
            int numeroLimitador;

            Console.Write("\n\nInforme um número inicial para verificar: ");
            numeroLimitador = int.Parse(Console.ReadLine());
            Console.WriteLine("\nOs números primos iniciais são!");

            CriaVetor(numeroLimitador);
        }

        static int[] CriaVetor(int numeroDigitado)
        {
            int contador = 0, tamanhoVetorNumerosPrimos = 0; ;
            tamanhoVetorNumerosPrimos = DeterminaTamanhoVetorNumerosPrimos(numeroDigitado);

            int[] vetorInicial = new int[tamanhoVetorNumerosPrimos + 1];

            Console.Write("[ ");

            for (int i = 0; i <= numeroDigitado; i++)
            {
                if (numeroDigitado % 2 != 0)
                {
                    vetorInicial[contador] = numeroDigitado;
                    Console.Write(vetorInicial[contador] + " , ");
                    numeroDigitado--;
                    contador++;
                }

            }

            Console.Write("]\n\n\n");
            return (vetorInicial);
        }

        static int DeterminaTamanhoVetorNumerosPrimos(int numeroDigitado)
        {
            int i, quantidadeNumerosPrimos = 0;

            for (i = numeroDigitado; i > 0; i--)
            {
                if (numeroDigitado % 2 != 0)
                {
                    quantidadeNumerosPrimos++;
                    numeroDigitado--;
                }
                else
                {
                    numeroDigitado--;
                }

            }
            return (quantidadeNumerosPrimos);
        }
    }
}
